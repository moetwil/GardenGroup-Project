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
    public class TicketSortService
    {
        private TicketDao ticketDao;
        
        public TicketSortService()
        {
            this.ticketDao = new TicketDao();
        }
        
        public List<Ticket> SortTicketsByPriority(bool descending)
        {
            if (descending)
                return ticketDao.SortTicketsByPriorityDescending();
            
            return ticketDao.SortTicketsByPriorityAscending();
        }

        public List<Ticket> SortTicketsByPriority(User user, SortDefinition<Ticket> sortOrder)
        {
            return ticketDao.SortTicketsByPriority(user, sortOrder);
        }

        // Tweede mogelijkheid
        public List<Ticket> SortTicketsByPriority(List<Ticket> tickets)
        {           
            return tickets.OrderBy(t => t.TicketPriority).ToList();
        }
    }
}
