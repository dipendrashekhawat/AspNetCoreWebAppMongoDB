using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDBCRUD.Models
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("Kids")]
        public string Kids { get; set; }

        [BsonElement("Home")]
        public string Home { get; set; }
    }
}
