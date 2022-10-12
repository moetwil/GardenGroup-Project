using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAL
{
    public class TicketPriorityDao : BaseDao
    {
        // get all  - get by Id bij alle DAO van Ticket.
        public IMongoCollection<TicketPriority> m_Collection { get; set; }
        public TicketPriorityDao()
        {
            m_Collection = this.m_Database.GetCollection<TicketPriority>("TicketPriorities");
        }
        // get by id
        public TicketPriority GetTicketPriorityById(string id)
        {
            return GetDocumentById<TicketPriority>(m_Collection, id);
        }

        // get all ticketPriorities
        public List<TicketPriority> GetAllPriorities()
        {
            return GetAllDocuments<TicketPriority>(this.m_Collection);
        }

    }
}
