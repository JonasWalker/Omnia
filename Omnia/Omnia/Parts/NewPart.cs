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
                    "VALUES (\'" + PartIDTextBox.Text + "\','" + PartNumberTextBox.Text + "\',\'" + PartDescriptionTextBox.Text + "\',\'" + PartQuantityTextBox.Text + "\',\'"
                    + Convert.ToDecimal(MSRPTextBox.Text) + "\',\'" + Convert.ToDecimal(CostTextBox.Text) + "\',\'" + NotesTextBox.Text + "\');";
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

        private void PartQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void MSRPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PartQuantityTextBox_Leave(object sender, EventArgs e)
        {
            if (PartQuantityTextBox.Text != "")
            {
                PartQuantityTextBox.Text = Convert.ToDouble(PartQuantityTextBox.Text).ToString("0.00");
            }
            else
            {
                PartQuantityTextBox.Text = "0.00";
            }
        }

        private void MSRPTextBox_Leave(object sender, EventArgs e)
        {
            if (MSRPTextBox.Text != "")
            {
                MSRPTextBox.Text = Convert.ToDouble(MSRPTextBox.Text).ToString("0.00");
            }
            else
            {
                MSRPTextBox.Text = "0.00";
            }
        }

        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            if (CostTextBox.Text != "")
            {
                CostTextBox.Text = Convert.ToDouble(CostTextBox.Text).ToString("0.00");
            }
            else
            {
                CostTextBox.Text = "0.00";
            }
        }
    }
}
