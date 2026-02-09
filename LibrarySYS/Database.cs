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
            try
            {
                string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string filePath = Path.Combine(userProfilePath + "\\OneDrive - Munster Technological University", "Documents", "OracleConnectionStringMTU.txt");

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"Connection string file not found: {filePath}");
                }

                string connectionString = File.ReadAllText(filePath).Trim();

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    throw new InvalidDataException("Oracle connection string file is empty");
                }

                return connectionString;
            } catch (Exception ex)
            {
                throw new Exception("Failed to load oracle connection string from user profile", ex);
            }
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
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            conn.Close();

            return ds;
        }


        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            return dr;

        }

        public static void ExecuteNonQuery(string query)
        {
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query, conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
