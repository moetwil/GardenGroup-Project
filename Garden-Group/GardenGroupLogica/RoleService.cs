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
    public class RoleService
    {

        private RoleDao roleDao;

        public RoleService()
        {
            this.roleDao = new RoleDao();
        }

        public Role GetRoleById(string id)
        {
            return this.roleDao.GetRoleById(id);
        }
        
        public List<Role> GetAllRoles()
        {
            return this.roleDao.GetAllRoles();
        }
    }
}