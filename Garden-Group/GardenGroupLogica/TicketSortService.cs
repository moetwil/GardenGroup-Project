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
            SortDefinition<Ticket> sort = Builders<Ticket>.Sort.Descending("TicketPriority");

            if (!descending)
                sort = Builders<Ticket>.Sort.Ascending("TicketPriority");

            return ticketDao.SortTicketsByPriority(sort);
        }

        public List<Ticket> SortTicketsByPriority(User user, bool descending)
        {
            SortDefinition<Ticket> sort = Builders<Ticket>.Sort.Descending("TicketPriority");
            
            if (!descending)
                sort = Builders<Ticket>.Sort.Ascending("TicketPriority");
            
            return ticketDao.SortTicketsByPriority(user, sort);
        }

        // Tweede mogelijkheid
        public List<Ticket> SortTicketsByPriority(List<Ticket> tickets)
        {           
            return tickets.OrderBy(t => t.TicketPriority).ToList();
        }
    }
}
