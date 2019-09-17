using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProfloPortalBackend.Model
{
    public class Card
    {
        [BsonId]
        [BsonElement("cardId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CardId { get; set; }
        [BsonElement("listId")]
        public string ListId { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("cardtitle")]
        public string CardTitle { get; set; }
        [BsonElement("creationDate")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        [BsonElement("dueDate")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        [BsonElement("assignees")]
        public List<Member> Assignees { get; set; }
        [BsonElement("labels")]
        public List<Label> Labels { get; set; }
        [BsonElement("attachments")]
        public List<Attachment> Attachments { get; set; }
        [BsonElement("comments")]
        public List<Comment> Comments { get; set; }
        [BsonElement("cardInvites")]
        public List<Invitee> CardInvites { get; set; }
        

    }
}
