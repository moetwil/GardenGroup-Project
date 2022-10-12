using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAL
{
    public class TicketStateDao : BaseDao
    {
        public IMongoCollection<TicketState> m_Collection { get; set; }
        public TicketStateDao()
        {
            m_Collection = this.m_Database.GetCollection<TicketState>("TicketStates");
        }
        public TicketState FindTicketStateByState(string name)
        {
            return m_Collection.Find(ticketState => ticketState.Name == name).FirstOrDefault();
        }
        // get by id
        public TicketState GetTicketStateById(string id)
        {
            return GetDocumentById<TicketState>(m_Collection, id);
        }
        // get all ticketStates
        public List<TicketState> GetAllTicketStates()
        {
            return GetAllDocuments<TicketState>(this.m_Collection);
        }

    }
}
