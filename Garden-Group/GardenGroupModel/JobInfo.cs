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
    public class JobInfo
    {
        public Role Role { get; set; }
        public Branch Branch { get; set; } 
    }
}
