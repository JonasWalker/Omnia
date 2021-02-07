using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Omnia
{
    class CustomersDatabaseSearch
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "omnia";
        private const String UID = "JonasWalker";
        private const String PASSWORD = "jonas1999";
        private static MySqlConnection dbConn;

        public String idcustomers { get; private set; }
        public String customerName { get; private set; }
        public String customerPhoneNumber { get; private set; }
        public String customerAltPhoneNumber { get; private set; }
        public String customerAddress { get; private set; }
        public String customerZIPCode { get; private set; }
        public String customerState { get; private set; }

        private CustomersDatabaseSearch(String id, String cN, String cP, String cAP, String cA, String cZ, String cS)
        {
            idcustomers = id;
            customerName = cN;
            customerPhoneNumber = cP;
            customerAltPhoneNumber = cAP;
            customerAddress = cA;
            customerZIPCode = cZ;
            customerState = cS;
        }
        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;
            String connString = builder.ToString();
            builder = null;
            Console.WriteLine(connString);
            dbConn = new MySqlConnection(connString);
        }

        public static List<CustomersDatabaseSearch> GetAllCustomers()
        {
            List<CustomersDatabaseSearch> customers = new List<CustomersDatabaseSearch>();
            String query = "SELECT * FROM omnia.customers;";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String idcustomers = reader["idcustomers"].ToString();
                String customerName = reader["customerName"].ToString();
                String customerPhoneNumber = reader["customerPhoneNumber"].ToString();
                String customerAltPhoneNumber = reader["customerAltPhoneNumber"].ToString();
                String customerAddress = reader["customerAddress"].ToString();
                String customerZIPCode = reader["customerZIPCode"].ToString();
                String customerState = reader["customerState"].ToString();

                CustomersDatabaseSearch u = new CustomersDatabaseSearch(idcustomers, customerName, customerPhoneNumber, customerAltPhoneNumber, customerAddress, customerZIPCode, customerState);

                customers.Add(u);

            }

            dbConn.Close();


            return customers;
        }

        public static List<CustomersDatabaseSearch> GetSearchedCustomers(String text = null, String text2 = null)
        {
            List<CustomersDatabaseSearch> customers = new List<CustomersDatabaseSearch>();
            String query;

            if (text != null && text2 == null)
            {
                query = "SELECT * FROM omnia.customers where customerName LIKE \"%" + text + "%\" ORDER BY customerName ASC;";
            }
            else if (text == null && text2 != null)
            {
                query = "SELECT * FROM omnia.customers where customerPhoneNumber LIKE \"%" + text2 + "%\"ORDER BY customerPhoneNumber ASC;";
            }
            else
            {
                query = "SELECT * FROM omnia.customers where customerName LIKE \"%" + text +
                    "%\" AND customerPhoneNumber LIKE \"%" + text2 + "%\" ORDER BY customerName ASC;";
            }

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String idcustomers = reader["idcustomers"].ToString();
                String customerName = reader["customerName"].ToString();
                String customerPhoneNumber = reader["customerPhoneNumber"].ToString();
                String customerAltPhoneNumber = reader["customerAltPhoneNumber"].ToString();
                String customerAddress = reader["customerAddress"].ToString();
                String customerZIPCode = reader["customerZIPCode"].ToString();
                String customerState = reader["customerState"].ToString();

                CustomersDatabaseSearch u = new CustomersDatabaseSearch(idcustomers, customerName, customerPhoneNumber, customerAltPhoneNumber, customerAddress, customerZIPCode, customerState);

                customers.Add(u);
            }

            dbConn.Close();

            return customers;
        }

    }
}
