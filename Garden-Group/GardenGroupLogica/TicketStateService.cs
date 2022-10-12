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
    public class TicketStateService
    {
        private TicketStateDao ticketStateDao;
        public TicketStateService()
        {
            ticketStateDao = new TicketStateDao();
        }

        public TicketState FindTicketStateByState(string name)
        {
            return ticketStateDao.FindTicketStateByState(name);
        }
        // get by id
        public TicketState GetTicketStateById(string id)
        {
            return ticketStateDao.GetTicketStateById(id);
        }
        // get all ticketStates
        public List<TicketState> GetAllTicketStates()
        {
            return ticketStateDao.GetAllTicketStates();
        }
    }
}
