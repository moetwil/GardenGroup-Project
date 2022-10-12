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
    public class RoleDao : BaseDao
    {
        public IMongoCollection<Role> m_Collection { get; set; }

        public RoleDao()
        {
        m_Collection = this.m_Database.GetCollection<Role>("Roles");
        }

        public List<Role> GetAllRoles()
        {
            return GetAllDocuments<Role>(m_Collection);
        }

        public Role GetRoleById(string id)
        {
            return this.GetDocumentById(m_Collection, id);
        }

    }
}
