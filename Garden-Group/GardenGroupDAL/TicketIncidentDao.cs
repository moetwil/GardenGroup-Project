using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAL
{
    public class TicketIncidentDao : BaseDao
    {
        public IMongoCollection<TicketIncident> m_Collection { get; set; }

        public TicketIncidentDao()
        {
            m_Collection = this.m_Database.GetCollection<TicketIncident>("TicketIncidents");
        }
        // get by id
        public TicketIncident GetTicketIncidentById(string id)
        {
            return GetDocumentById<TicketIncident>(m_Collection, id);
        }
        // get all ticketIncidents
        public List<TicketIncident> GetAllTicketIncidents() {
            return GetAllDocuments<TicketIncident>(this.m_Collection);
        }

    }
}
