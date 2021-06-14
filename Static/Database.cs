using System;
using System.Text;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291CarProject.Static
{
    public static class Database
    {
        private static SqlConnection connection;
        public static SqlCommand commandStream = new SqlCommand();
        public static SqlDataReader dataStream;

        public const string host = "DESKTOP-T4FGG00";
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

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString(), "Error");
            }
        }

        public static bool CreateUser(string username, string password, string gender, string firstName, string lastName, string street, string city, string province)
        {
            bool status = false;

            StringBuilder createUserString = new StringBuilder("INSERT INTO [User] VALUES ('");

            createUserString.Append(username + "', '");
            createUserString.Append(password + "', 'Customer', '");
            createUserString.Append(gender + "', '");
            createUserString.Append(firstName + "', '");
            createUserString.Append(lastName + "', '");
            createUserString.Append(street + "', '");
            createUserString.Append(city + "', '");
            createUserString.Append(province + "')");

            Debug.WriteLine("CreateUserString: " + createUserString.ToString());

            commandStream.CommandText = createUserString.ToString();

            try
            {
                dataStream = commandStream.ExecuteReader();

                status = true;

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());

                status = false;
            }

            dataStream.Close();

            return status;
        }

        public static bool UserExists(string username)
        {
            bool status = false;

            commandStream.CommandText = "SELECT * FROM [User] WHERE userName='" + username + "'";

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    string dataStreamUsername = dataStream["userName"].ToString();

                    if (dataStream["userName"].ToString().Equals(username, StringComparison.OrdinalIgnoreCase))
                        status = true;
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("[UserExists] An error has occurred");
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return status;
        }

        public static bool VerifyPassword(string username, string password)
        {
            bool status = false;

            commandStream.CommandText = "SELECT * FROM [User] WHERE userName='" + username + "'";

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    if (!dataStream["userName"].ToString().Equals(username, StringComparison.OrdinalIgnoreCase))
                        break;

                    if (!dataStream["passw"].ToString().Equals(password))
                        break;

                    status = true;
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occurred");
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return status;
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