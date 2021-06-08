using System;
using System.Text;
using System.Diagnostics;
using System.Data.SqlClient;

namespace _291CarProject.Static
{
    public static class Database
    {
        private static SqlConnection connection;
        public static SqlCommand commandStream = new SqlCommand();
        public static SqlDataReader dataStream;

        public const string host = "localhost";
        public const string database = "291proDatabase";

        public const string username = "user2";
        public const string password = "pass1";

        public const int timeout = 15; // Connection timeout duration

        public static void CreateConnection()
        {
            connection = new SqlConnection(getConnectionString());

            try
            {
                connection.Open();
                
                commandStream.Connection = connection;

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString(), "Error");
            }
        }

        public static bool VerifyPassword(string username, string password)
        {
            commandStream.CommandText = "SELECT * FROM Employee WHERE Employee.username=" + username;

            try
            {
                dataStream = commandStream.ExecuteReader();

                Debug.WriteLine(dataStream.Read());

            } catch (Exception e)
            {
                Debug.WriteLine("An error has occurred");
                Debug.WriteLine(e.ToString());
            }

            return false;
        }

        private static string getConnectionString()
        {
            StringBuilder connectionString = new StringBuilder("user id=");

            connectionString.Append(username + ";password=");
            connectionString.Append(password + ";server=");
            connectionString.Append(host + ";database=");
            connectionString.Append(database + ";connection timeout=");
            connectionString.Append(timeout);

            return connectionString.ToString();
        }
    }
}
