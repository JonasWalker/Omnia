using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Omnia
{
    public partial class NewPart : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "omnia";
        private const String UID = "JonasWalker";
        private const String PASSWORD = "jonas1999";
        private static MySqlConnection dbConn;

        public NewPart()
        {
            InitializeDB();
            InitializeComponent();
            HighestID();
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PartNumberTextBox.Text = "";
            PartDescriptionTextBox.Text = "";
            PartQuantityTextBox.Text = "";
            MSRPTextBox.Text = "";
            CostTextBox.Text = "";
            NotesTextBox.Text = "";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (PartNumberTextBox.Text != "" && PartDescriptionTextBox.Text != "" && PartQuantityTextBox.Text != "" && 
                MSRPTextBox.Text != "" && CostTextBox.Text != "" && NotesTextBox.Text != "")
            {
                String query = "INSERT INTO omnia.parts (idparts, partNumber, partDescription, partQty, partMSRP, partCost, partNote) " +
                    "VALUES (\'" + PartIDTextBox.Text + "\',\'" + PartNumberTextBox.Text + "\',\'" + PartDescriptionTextBox.Text + "\',\'" + PartQuantityTextBox.Text + "\',\'"
                    + Convert.ToDecimal(MSRPTextBox.Text) + "\',\'" + Convert.ToDecimal(CostTextBox.Text) + "\',\'" + NotesTextBox.Text + "\');";
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

        private void NewPart_Load(object sender, EventArgs e)
        {

        }

        private void HighestID()
        {
            String query = "SELECT max(idparts) FROM omnia.parts;";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idparts = (int)reader["max(idparts)"] + 1;
                PartIDTextBox.Text = idparts.ToString();
            }
            dbConn.Close();
        }
    }
}
