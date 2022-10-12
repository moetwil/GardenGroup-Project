using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace GardenGroupModel
{
    public class Password
    {
        public string Hash { get; set; }
        public string Salt { get; set; }

        public Password(string hash, string salt)
        {
            Hash = hash;
            Salt = salt;
        }
    }
}
