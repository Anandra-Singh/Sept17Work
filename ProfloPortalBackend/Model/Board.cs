﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfloPortalBackend.Model
{
    [BsonIgnoreExtraElements]
    public class Board
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BoardId { get; set; }
        [BsonElement("teamId")]
        public string TeamId { get; set; } 
        [BsonElement("boardname")]
        public string BoardName { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        public List<Member> BoardMembers { get; set; }
        public List<Invitee> BoardInvites { get; set; }
        public List<List> BoardLists { get; set; }

    }
}
