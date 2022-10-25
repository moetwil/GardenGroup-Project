using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupModel
{
    public class ErrorLog
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]


        private static ErrorLog instance;

        private ErrorLog() { }

        public static ErrorLog GetInstance()
        {
            if (instance == null)
            {
                instance = new ErrorLog();
            }

            return instance;
        }


        public string? Id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
