using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.Generic;

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
        public List<Kid> Kids { get; set; }

        [BsonElement("Home")]
        public List<Home> Home { get; set; }

    }

    public class Home
    {
        public string homeType { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
    }

    public class Kid
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
}
