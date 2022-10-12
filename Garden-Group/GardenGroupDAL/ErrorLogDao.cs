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
    public class ErrorLogDao : BaseDao
    {
        public IMongoCollection<ErrorLog> m_Collection { get; set; }

        public ErrorLogDao()
        {
            m_Collection = this.m_Database.GetCollection<ErrorLog>("ErrorLog");
        }

        public void AddErrorLog(ErrorLog errorLog)
        {
            m_Collection.InsertOne(errorLog);
        }
    }
}
