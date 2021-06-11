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

        public const string host = "DESKTOP-GCF4I8G";
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

        public static bool CreateUser(string username, string password, string gender, string firstName, string lastName, string street, string city, string province)
        {
            StringBuilder createUserString = new StringBuilder("INSERT INTO [User] VALUES ('");

            createUserString.Append(username + "', '");
            createUserString.Append(password + "', 'Customer', '");
            createUserString.Append(gender + "', '");
            createUserString.Append(firstName + "', '");
            createUserString.Append(lastName + "', '");
            createUserString.Append(street + "', '");
            createUserString.Append(city + "', '");
            createUserString.Append(province + "')");

            commandStream.CommandText = createUserString.ToString();

            try
            {
                dataStream = commandStream.ExecuteReader();

                dataStream.Close();

                return true;

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());

                return false;
            }
        }

        public static bool UserExists(string username)
        {
            commandStream.CommandText = "SELECT * FROM [User] WHERE userName='" + username + "'";

            try
            {
                dataStream = commandStream.ExecuteReader();
                dataStream.Read();

                string dataStreamUsername = dataStream["userName"].ToString();

                Debug.WriteLine(dataStreamUsername.Length);
                Debug.WriteLine(username.Length);

                Debug.WriteLine(".." + dataStreamUsername + "..");
                Debug.WriteLine(dataStreamUsername.Equals(username, StringComparison.OrdinalIgnoreCase));
                
                if (dataStream["userName"].ToString().ToLower().Equals(username.ToLower()))
                    return true;

                dataStream.Close();

            } catch (Exception e)
            {
                Debug.WriteLine("An error has occurred");
                Debug.WriteLine(e.ToString());
            }

            return false;
        }

        public static bool VerifyPassword(string username, string password)
        {
            commandStream.CommandText = "SELECT * FROM [User] WHERE userName='" + username + "'";

            try
            {
                dataStream = commandStream.ExecuteReader();

                Debug.WriteLine(dataStream.Read());

                dataStream.Close();

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
