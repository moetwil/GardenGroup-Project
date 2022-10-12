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
    public class TicketIncidentService
    {
        private TicketIncidentDao ticketIncidentDao;

        public TicketIncidentService()
        {
            ticketIncidentDao = new TicketIncidentDao();
        }

        // get by id
        public TicketIncident GetTicketIncidentById(string id)
        {
            return ticketIncidentDao.GetTicketIncidentById(id);
        }
        // get all ticketIncidents
        public List<TicketIncident> GetAllTicketIncidents()
        {
            return ticketIncidentDao.GetAllTicketIncidents();
        }
    }
}
