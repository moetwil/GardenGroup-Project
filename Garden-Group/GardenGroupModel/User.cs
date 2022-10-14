using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace GardenGroupModel
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public JobInfo JobInfo { get; set; }
        
        public List<string> TicketsIds { get; set; }
        public Password Password { get; set; }
        public List<Ticket> Tickets { get; set; }

        public User()
        {
            this.ContactInfo = new ContactInfo();
            this.JobInfo = new JobInfo();
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }

    }
}