using MongoDB.Bson.Serialization.Attributes;
namespace MongoDBCRUD.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Email")]
        public int Email { get; set; }

        [BsonElement("PhoneNumber")]
        public int PhoneNumber { get; set; }

        [BsonElement("Kids")]
        public int Kids { get; set; }

        [BsonElement("Home")]
        public int Home { get; set; }
    }
}
