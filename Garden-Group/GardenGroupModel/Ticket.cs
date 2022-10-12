using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel.Enums;

namespace GardenGroupModel
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        
        public string? Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        [BsonIgnore]
        public User Creator { get; set; }
        public string CreatorID { get; set; }
        public TicketState TicketState { get; set; }
        public TicketPriority TicketPriority { get; set; }
        public TicketIncident TypeOfIncident { get; set; }
        

        [BsonIgnore]
        public List<User> Solvers { get; set; }
        public List<string> TicketSolvers { get; set; }
        public TicketDate TicketDate { get; set; }

        public Ticket()
        {
            this.TicketSolvers = new List<string>();
        }
    }
}
