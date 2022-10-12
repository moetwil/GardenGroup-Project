using GardenGroupDAL;
using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogica
{
    public class UserService
    {

        private UserDao userDao;

        public UserService()
        {
            this.userDao = new UserDao();
        }

        public User FindUserByFirstName(string firstName)
        {
          return  userDao.FindUserByFirstName(firstName);
        }

        public User FindUserById(string id)
        {
            return this.userDao.FindUserById(id);
        }
        public User GetUserById(string id)
        {
            return this.userDao.FindUserById(id);
        }

        public User FindUserByEmail(string email)
        {
            return this.userDao.FindUserByEmail(email);
        }
        
        public bool CheckIfEmailExists(string email)
        {
            return this.userDao.CheckIfEmailExists(email);
        }

        public void UpdatePassword(string email, User user)
        {
            this.userDao.UpdatePassword(email, user);
        }

        public void AddUser(User user)
        {
            userDao.AddUser(user);
        }

        public void DeleteUser(string id)
        {
            this.userDao.DeleteUser(id);
        }

        public void InsertUser(User user)
        {
            this.userDao.InsertUser(user);
        }

        public void UpdateDocument(User user)
        {
            //this.userDao.UpdateDocument(user);
        }

        public List<User> GetAllUsers()
        {
            return this.userDao.GetAllUsers();
        }
        public List<User> GetTicketSolvers(List<string> ticketSolvers)
        {
            List<User> users = new List<User>();
            foreach (string ticketSolver in ticketSolvers)
            {
                User user = this.userDao.FindUserById(ticketSolver);
                users.Add(user);
            }
            return users;
        }
    }
}