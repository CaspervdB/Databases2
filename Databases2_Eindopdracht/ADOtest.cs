using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Databases2_Eindopdracht
{
    class ADOtest : GenericTest
    {

        private string connectionString = "Server = localhost; Database = netflix; Integrated Security= SSPI; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        override public void CleanDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string delete = $"DELETE FROM [Account] WHERE Password = 'StrongPassword123';";
                SqlCommand command = new SqlCommand(delete, connection);
                command.ExecuteNonQuery(); ;
                connection.Close();
            }
        }

        override public TimeSpan RunCreate(int n)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var timeSpan = RunTemplate((int i) =>
                {
                    string insert = $"INSERT INTO [Account] (AccountId, MailAdress, Password, AccountActivated, DateStarted, NumberOfProfiles, Invited, FriendId, SubscriptionId) VALUES ({i}, 'charlesboyle@nypd.com', 'StrongPassword123', '1', '2021-06-25 16:30:20', '1', '0', '21','1');";
                    SqlCommand command = new SqlCommand(insert, connection);
                    command.ExecuteNonQuery();
                }, n);
                connection.Close();
                return timeSpan;
            }
        }

        override public TimeSpan RunRead(int n)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var timeSpan = RunTemplate((int i) =>
                {
                    string select = $"SELECT * FROM [Account] WHERE AccountId = {i};";
                    SqlCommand command = new SqlCommand(select, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }, n);
                connection.Close();
                return timeSpan;
            }
        }

        override public TimeSpan RunUpdate(int n)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var timeSpan = RunTemplate((int i) =>
                {
                    string update = $"UPDATE [Account] SET MailAdress = 'frontoffice@nypd.com' WHERE AccountId = {i};";
                    SqlCommand command = new SqlCommand(update, connection);
                    command.ExecuteNonQuery(); ;
                }, n);
                connection.Close();
                return timeSpan;
            }
        }

        override public TimeSpan RunDelete(int n)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var timeSpan = RunTemplate((int i) =>
                {
                    string delete = $"DELETE FROM [Account] WHERE AccountId = {i};";
                    SqlCommand command = new SqlCommand(delete, connection);
                    command.ExecuteNonQuery(); ;
                }, n);
                connection.Close();
                return timeSpan;
            }
        }
    }
}
