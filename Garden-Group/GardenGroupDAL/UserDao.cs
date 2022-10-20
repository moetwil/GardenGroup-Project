using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenGroupDAL
{
    public class UserDao : BaseDao
    {
        public IMongoCollection<User> m_Collection { get; set; }

        public UserDao()
        {
        m_Collection = this.m_Database.GetCollection<User>("Users");
        }

        public List<User> GetAllUsers()
        {
            // old
            //return GetAllDocuments<User>(m_Collection);
            

            List<User> users = this.m_Collection.Aggregate()
                .Lookup("Tickets", "_id", "CreatorId", "Tickets")
                .As<User>().ToList();

            return users;
        }

        public User FindUserByFirstName(string firstName)
        {
            User user = m_Collection.Find(user => user.FirstName.Equals(firstName)).FirstOrDefault();
            return user;
        }

        public User FindUserById(string id)
        {
            return this.GetDocumentById(m_Collection, id);
        }
        
        public User FindUserByEmail(string email)
        {
            // error handling?
            return this.m_Collection.Aggregate()
                .Lookup("Tickets", "_id", "CreatorId", "Tickets")
                .Match(new BsonDocument("ContactInfo.Email", email))
                .As<User>().ToList().FirstOrDefault();
        }


        public bool CheckIfEmailExists(string email)
        {
            User user = m_Collection.Find(user => user.ContactInfo.Email.Equals(email)).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }
        
        public void UpdatePassword(string email, User user)
        {
            m_Collection.UpdateOne(Builders<User>.Filter.Eq("ContactInfo.Email", email), Builders<User>.Update.Set("Password", user.Password));
        }

        public void AddUser(User user)
        {
            m_Collection.InsertOne(user);
        }

        public void DeleteUser(string id)
        {
            this.DeleteById(m_Collection, id);
        }

        public void InsertUser(User user)
        {
            this.InsertDocument(m_Collection, user);
        }

        public void UpdateUser(User user)
        {
            this.UpdateDocument(m_Collection,user.Id, user);
        }
    }
}
