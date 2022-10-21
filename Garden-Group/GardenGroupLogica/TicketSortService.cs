using GardenGroupDAL;
using GardenGroupModel;
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

        // Tweede mogelijkheid
        public List<Ticket> SortTicketsByPriority(List<Ticket> tickets)
        {           
            return tickets.OrderBy(t => t.TicketPriority).ToList();
        }
    }
}
