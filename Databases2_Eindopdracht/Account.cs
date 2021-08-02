using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    [BsonDiscriminator("account")]
    class Account
    {
        [Key]
        public int AccountId { get; set; }

        public string MailAdress { get; set; }

        public string Password { get; set; }

        public bool AccountActivated { get; set; }

        public DateTime DateStarted { get; set; }

        public int NumberOfProfiles { get; set; }

        public bool Invited { get; set; }

        public int FriendId { get; set; }

        public int SubscriptionId { get; set; }
    }
}
