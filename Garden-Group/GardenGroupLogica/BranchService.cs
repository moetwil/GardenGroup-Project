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
    public class BranchService
    {

        private BranchDao branchDao;

        public BranchService()
        {
            this.branchDao = new BranchDao();
        }

        public Branch GetRoleById(string id)
        {
            return this.branchDao.GetBranchById(id);
        }
        
        public List<Branch> GetAllBranches()
        {
            return this.branchDao.GetAllBranches();
        }
    }
}