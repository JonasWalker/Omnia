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
    public partial class NewRepair : Form
    {
        public NewRepair()
        {
            InitializeComponent();
            InitializeDB();
            HighestID();
        }

        private void NewRepair_Load(object sender, EventArgs e)
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
            String query = "SELECT max(repairID) FROM omnia.repairs;";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idparts = (int)reader["max(repairID)"] + 1;
                RepairIDTextBox.Text = idparts.ToString();
            }
            dbConn.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (repairTagNumberTextBox.Text != "" && repairCustomerNameTextBox.Text != "" && repairCustomerPhoneNumberTextBox.Text != "" &&
                repairDescriptionTextBox.Text != "" && repairModelTextBox.Text != "" && repairSerialTextBox.Text != "" && repairNotesTextBox.Text != "")
            {
                String query = "INSERT INTO omnia.repairs (repairID, repairTag, repairCustName, repairCustPhoneNumber, repairDescription, repairModel, repairSerial, repairNotes) " +
                    "VALUES (\'" + RepairIDTextBox.Text + "\',\'" + repairTagNumberTextBox.Text + "\',\'" + repairCustomerNameTextBox.Text + "\',\'" + repairCustomerPhoneNumberTextBox.Text + "\',\'"
                    + repairDescriptionTextBox.Text + "\',\'" + repairModelTextBox.Text + "\',\'" + repairSerialTextBox.Text + "\',\'"+ repairNotesTextBox.Text + "\');";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dbConn.Close();
                this.Close();
            }
            else
            {
                ErrorMessage error = new ErrorMessage("Not all fields were filled.");
                error.ShowDialog();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            repairTagNumberTextBox.Text = "";
            repairCustomerNameTextBox.Text = "";
            repairCustomerPhoneNumberTextBox.Text = "";
            repairDescriptionTextBox.Text = "";
            repairModelTextBox.Text = "";
            repairSerialTextBox.Text = "";
            repairNotesTextBox.Text = "";
        }
    }
}
