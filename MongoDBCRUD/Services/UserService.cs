using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDBCRUD.Models;
using System.Collections.Generic;

namespace MongoDBCRUD.Services
{
    public class UserService
    {`
        private readonly IMongoCollection<User> users;

        public UserService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("UserDetailsDB"));
            IMongoDatabase database = client.GetDatabase("Users");
            users = database.GetCollection<User>("users");
        }

        public List<User> Get()
        {
            return users.Find(user => true).ToList();
        }

        public User Get(string id)
        {
            return users.Find(user => user.Id == id).FirstOrDefault();
        }
    }
}
