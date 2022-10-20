using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using GardenGroupModel;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAL
{
    public abstract class BaseDao
    {
        protected MongoClient m_Client;
        protected IMongoDatabase m_Database;

       
        protected BaseDao()
        { 
            m_Client = new MongoClient(ConfigurationManager.ConnectionStrings["GardenGroupDatabase"].ConnectionString);
            m_Database = m_Client.GetDatabase("ProjectNoSQL");
        }

        // add document to collection
        protected void InsertDocument<T>(IMongoCollection<T> collection, T document)
        {
            collection.InsertOne(document);
        }

        // update document in collection
        protected void UpdateDocument<T>(IMongoCollection<T> collection, string id, T document)
        {
            collection.ReplaceOne(
                new BsonDocument("_id", ObjectId.Parse(id)), document, new ReplaceOptions { IsUpsert = true });
        }

        // Get All documents from a collection
        protected List<T> GetAllDocuments<T>(IMongoCollection<T> collection)
        {
            return collection.Find(new BsonDocument()).ToList();

        }

        // Get document by id
        protected T GetDocumentById<T>(IMongoCollection<T> collection, string id)
        {
            return collection.Find(new BsonDocument("_id", ObjectId.Parse(id))).FirstOrDefault();
        }

        // Delete document by id
        protected void DeleteById<T>(IMongoCollection<T> collection, string id)
        {
            collection.DeleteOne(new BsonDocument("_id", ObjectId.Parse(id)));
        }
        // Get all documents/tickets from a specifik user by creators ID
        protected List<T> GetDocumentsByCreator<T>(IMongoCollection<T> collection, User user)
        {
            return collection.Find(new BsonDocument("CreatorID", user.Id)).ToList();
        }
    }
}
