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
        public String customerNotes { get; private set; }

        public Customer customer { get; private set; }

        public struct Customer {
            public String customerID;
            public String customerName;
            public String customerPhoneNumber;
            public String customerAltPhoneNumber;
            public String customerAddress;
            public String customerZIPCode;
            public String customerState;
            public String customerNotes;

            public Customer(String _customerID = null, String _customerName = null, String _customerPhoneNumber = null, String _customerAltPhoneNumber = null, String _customerAddress = null,
                String _customerZIPCode = null, String _customerState = null, String _customerNotes = null)
            {
                customerID = _customerID;
                customerName = _customerName;
                customerPhoneNumber = _customerPhoneNumber;
                customerAltPhoneNumber = _customerAltPhoneNumber;
                customerAddress = _customerAddress;
                customerZIPCode = _customerZIPCode;
                customerState = _customerState;
                customerNotes = _customerNotes;
            }
        }

        public CustomersDatabaseSearch(String _id)
        {
            idcustomers = _id;
            SearchForCustomerID();
        }

        private CustomersDatabaseSearch(String id, String cN, String cP, String cAP, String cA, String cZ, String cS, String nts)
        {
            idcustomers = id;
            customerName = cN;
            customerPhoneNumber = cP;
            customerAltPhoneNumber = cAP;
            customerAddress = cA;
            customerZIPCode = cZ;
            customerState = cS;
            customerNotes = nts;
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
                String customerNotes = reader["customerNotes"].ToString();

                CustomersDatabaseSearch u = new CustomersDatabaseSearch(idcustomers, customerName, customerPhoneNumber, customerAltPhoneNumber, customerAddress, customerZIPCode, customerState, customerNotes);

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
                String customerNotes = reader["customerNotes"].ToString();

                CustomersDatabaseSearch u = new CustomersDatabaseSearch(idcustomers, customerName, customerPhoneNumber, customerAltPhoneNumber, customerAddress, customerZIPCode, customerState, customerNotes);

                customers.Add(u);
            }

            dbConn.Close();

            return customers;
        }

        public void SearchForCustomerID()
        {
            String query = "SELECT * FROM omnia.customers WHERE idcustomers = \"" + idcustomers + "\";";
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
                String customerNotes = reader["customerNotes"].ToString();

                customer = new Customer(idcustomers, customerName, customerPhoneNumber, customerAltPhoneNumber, customerAddress, customerZIPCode, customerState, customerNotes);
            }
            dbConn.Close();
        }

        public void EditCustomerInfo(String _customerID, String _customerName, String _customerPhoneNumber, String _customerAltPhoneNumber, String _customerAddress,
                String _customerZIPCode, String _customerState, String _customerNotes)
        {
            String query = "UPDATE omnia.customers SET customerName = \'" + _customerName + "\', customerPhoneNumber = \'" + _customerPhoneNumber + "\', customerAltPhoneNumber = \'" + _customerAltPhoneNumber + "\', customerAddress = \'" + _customerAddress +
                "\', customerZIPCode = \'" + _customerZIPCode + "\', customerState = \'" + _customerState + "\', customerNotes = \'" + _customerNotes + "\'WHERE idcustomers = " + _customerID + ";";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            dbConn.Close();
        }

    }
}
