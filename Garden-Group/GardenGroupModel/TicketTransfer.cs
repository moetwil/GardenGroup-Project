using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupModel
{
    public class TicketTransfer
    {
        // old id
        public string ServiceDeskEmployeeOldId { get; set; }
        
        // new id
        public string ServiceDeskEmployeeNewId { get; set; }

        
    }
}
