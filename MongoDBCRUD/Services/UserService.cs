﻿using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDBCRUD.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MongoDBCRUD.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> users;

        public UserService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("UsersDb"));
            IMongoDatabase database = client.GetDatabase("Users");
            users = database.GetCollection<User>("userDetails");
        }


        /// <summary>
        /// Retrieving user details
        /// </summary>
        /// <returns></returns>
        public List<User> Get()
        {
            //var jObject = JsonConvert.DeserializeObject<User>(users.Find(user => true).ToList());
            return users.Find(user => true).ToList();
        }

        public User Get(string id)
        {
            return users.Find(user => user.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Creating a new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User Create(User user)
        {
            users.InsertOne(user);
            return user;
        }

        /// <summary>
        /// Updating the existing user information
        /// </summary>
        /// <param name="id"></param>
        /// <param name="existingUser"></param>
        public void Update(string id, User existingUser)
        {
            users.ReplaceOne(user => user.Id == id, existingUser);
        }

        /// <summary>
        /// Removing user details
        /// </summary>
        /// <param name="existingUser"></param>
        public void Delete(User existingUser)
        {
            users.DeleteOne(user => user.Id == existingUser.Id);

        }

        public void Delete(string id)
        {
            users.DeleteOne(user => user.Id == id);
        }

        public List<User> Search(int ageFilter, string stateFilter)
        {
            // LINQ to get list of user being searched.
            IQueryable<User> user = from u in users.AsQueryable()
                                    where u.Age > 0 && u.Age <= ageFilter
                                    select u;

            //var userDetails = users.AsQueryable().Where(u => u.Age >= Convert.ToInt32(searchQuery) && u.Age <= 30).ToList();

            if (!string.IsNullOrEmpty(stateFilter))
            {
                users.AsQueryable().Where(u => u.Home[0].state.Contains(stateFilter)).ToList();
            }

            return user.ToList();
        }
    }
}
