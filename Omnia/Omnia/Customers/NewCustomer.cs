using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Omnia
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
            InitializeDB();
            HighestID();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "omnia";
        private const String UID = "JonasWalker";
        private const String PASSWORD = "jonas1999";
        private static MySqlConnection dbConn;

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
        private void HighestID()
        {
            String query = "SELECT max(idcustomers) FROM omnia.customers;";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idparts = (int)reader["max(idcustomers)"] + 1;
                PartIDTextBox.Text = idparts.ToString();
            }
            dbConn.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text != "" && customerPhoneNumberTextBox.Text != "" && customerAltPhoneNumberTextBox.Text != "" &&
                customerAddressTextBox.Text != "" && customerZIPTextBox.Text != "" && customerStateTextBox.Text != "")
            {
                String query = "INSERT INTO omnia.customers (idcustomers, customerName, customerPhoneNumber, customerAltPhoneNumber, customerAddress, customerZIPCode, customerState) " +
                    "VALUES (\'" + PartIDTextBox.Text + "\',\'" + customerNameTextBox.Text + "\',\'" + customerPhoneNumberTextBox.Text + "\',\'" + customerAltPhoneNumberTextBox.Text + "\',\'"
                    + customerAddressTextBox.Text + "\',\'" + customerZIPTextBox.Text + "\',\'" + customerStateTextBox.Text + "\');";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dbConn.Close();
            }
            else
            {
                ErrorMessage error = new ErrorMessage("Not all fields were filled.");
                error.ShowDialog();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Text = "";
            customerPhoneNumberTextBox.Text = "";
            customerAltPhoneNumberTextBox.Text = "";
            customerAddressTextBox.Text = "";
            customerZIPTextBox.Text = "";
            customerStateTextBox.Text = "";
        }
    }
}
