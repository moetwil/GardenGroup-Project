using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupModel
{
    public class TicketDate
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        // Id eruit halen?? overbodig 
        public string? Id { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime Deadline { get; set; }
    }
}
