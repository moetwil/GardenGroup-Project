using GardenGroupDAL;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace GardenGroupLogica
{
    public class TicketPriorityService
    {
        private TicketPriorityDao ticketPriorityDao;

        public TicketPriorityService()
        {
            ticketPriorityDao = new TicketPriorityDao();
        }
        // get by id
        public TicketPriority GetTicketPriorityById(string id)
        {
            return ticketPriorityDao.GetTicketPriorityById(id);
        }

        // All ticket priorities
        public List<TicketPriority> GetAllTicketPriorities()
        {
            return ticketPriorityDao.GetAllPriorities();
        }
    }
}
