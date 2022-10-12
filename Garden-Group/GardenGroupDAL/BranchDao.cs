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
    public class BranchDao : BaseDao
    {
        public IMongoCollection<Branch> m_Collection { get; set; }

        public BranchDao()
        {
        m_Collection = this.m_Database.GetCollection<Branch>("Branches");
        }

        public List<Branch> GetAllBranches()
        {
            return GetAllDocuments<Branch>(m_Collection);
        }

        public Branch GetBranchById(string id)
        {
            return this.GetDocumentById(m_Collection, id);
        }

    }
}
