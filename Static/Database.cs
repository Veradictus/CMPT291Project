using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _291CarProject.Static
{
    class Database
    {
        private static SqlConnection connection;
        private static SqlCommand commandStream = new SqlCommand();
        private static SqlDataReader dataStream;

        public const string host = "localhost";
        public const string database = "prj291";

        public const string username = "user1";
        public const string password = "pass1";

        public const int timeout = 15; // Connection timeout duration

        public static void CreateConnection()
        {
            MessageBox.Show("Creating connection", "Error");
            MessageBox.Show(getConnectionString(), "Error");

            connection = new SqlConnection(getConnectionString());

            try
            {
                connection.Open();
                
                commandStream.Connection = connection;

            } catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
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
