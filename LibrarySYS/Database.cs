using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    class Database
    {
        private static string connectionString = LoadConnectionString();

        private static string LoadConnectionString()
        {
            
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = Path.Combine(userProfilePath + "\\OneDrive - Munster Technological University", "Documents", "OracleConnectionStringMTU.txt");

            System.Windows.Forms.MessageBox.Show(
                filePath
            );

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Connection string file not found: {filePath}");
            }

            return File.ReadAllText(filePath).Trim();
        }

        public static OracleConnection OpenConnection()
        {
            try
            {
                OracleConnection conn = new OracleConnection(Database.connectionString);
                conn.Open();
                Console.WriteLine("Connection to Oracle was successful");

                return conn;
            }
            catch (Exception ex)
            {
               throw new Exception("Error connecting to Oracle database: " + ex);
            }
        }

        public static DataSet ExecuteMultiRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Use an OracleDataAdapter as a bridge between the DB and an in-memory
            //data structure (a DataSet in this case)
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Create the DataSet to hold results of the query
            DataSet ds = new DataSet();

            //Populate the DataSet with the results of the query
            //Note that Fill() will use the OracleCommand object to execute query
            da.Fill(ds);

            //Close DB connection
            conn.Close();

            return ds;
        }


        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the query and atore the results in an OracleDataReader
            OracleDataReader dr = cmd.ExecuteReader();

            return dr;

        }

        public static void ExecuteNonQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the DB non-query
            cmd.ExecuteNonQuery();

            //Close the DB connection
            conn.Close();

        }
    }
}
