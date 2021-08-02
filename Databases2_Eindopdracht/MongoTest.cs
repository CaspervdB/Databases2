using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class MongoTest : GenericTest
    {
        private string connectionString = "mongodb://localhost:27017";
        private string databaseName = "netflixdb";
        private string accountsCollectionName = "accounts";
        private string wrongAttemptsCollectionName = "wrong_attempts";
        private string subscriptionsCollectionName = "subscriptions";

        override public void CleanDatabase()
        {
            var database = ConnectToMongoDatabase();
            database.DropCollection("accounts");
        }

        override public TimeSpan RunCreate(int n)
        {
            var accounts = ConnectToMongoCollection(accountsCollectionName);
            return RunTemplate((int i) => {
                var account = CreateAccount(i);
                var accountDocument = account.ToBsonDocument();
                accounts.InsertOne(accountDocument);
            }, n);
        }

        override public TimeSpan RunRead(int n)
        {
            var accounts = ConnectToMongoCollection(accountsCollectionName);
            return RunTemplate((int i) => {
                accounts.Find(new BsonDocument()).ToList();
            }, n);
        }

        override public TimeSpan RunUpdate(int n)
        {
            var accounts = ConnectToMongoCollection(accountsCollectionName);
            return RunTemplate((int i) => {
                var filter = Builders<BsonDocument>.Filter.Eq("AccountId", i);
                var update = Builders<BsonDocument>.Update.Set("MailAdress", "cptholt@nypd.com");
                accounts.UpdateOne(filter, update);
            }, n);
        }

        override public TimeSpan RunDelete(int n)
        {
            var accounts = ConnectToMongoCollection(accountsCollectionName);
            return RunTemplate((int i) => {
                var filter = Builders<BsonDocument>.Filter.Eq("AccountId", i);
                accounts.DeleteOne(filter);
            }, n);
        }

        private IMongoDatabase ConnectToMongoDatabase()
        {
            var client = new MongoClient(connectionString);
            return client.GetDatabase(databaseName);
        }

        private IMongoCollection<BsonDocument> ConnectToMongoCollection(string collectionName)
        {
            var database = ConnectToMongoDatabase();
            return database.GetCollection<BsonDocument>(collectionName);
        }
    }
}
