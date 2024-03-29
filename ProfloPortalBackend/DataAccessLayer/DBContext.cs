﻿using ProfloPortalBackend.Model;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfloPortalBackend.DataAccessLayer
{
    public class DBContext
    {
        MongoClient mongoClient;
        IMongoDatabase mongoDatabase;
        public DBContext(IConfiguration configuration)
        {
             mongoClient = new MongoClient(configuration.GetSection("MongoDb:server").Value);
           // mongoClient = new MongoClient(Environment.GetEnvironmentVariable("mongo_db"));
            mongoDatabase = mongoClient.GetDatabase(configuration.GetSection("MongoDB:database").Value);
        }
        public IMongoCollection<Team> Teams => mongoDatabase.GetCollection<Team>("Teams");
        public IMongoCollection<Card> Cards => mongoDatabase.GetCollection<Card>("Cards");
        public IMongoCollection<Board> Boards => mongoDatabase.GetCollection<Board>("Boards");
        public IMongoCollection<List> Lists => mongoDatabase.GetCollection<List>("Lists");
        //public IMongoCollection<Board> Boards => mongoDatabase.GetCollection<Board>("Boards" ;
    }
}
