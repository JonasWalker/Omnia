using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnia
{
    public partial class EditRepair : Form
    {
        private static String repairID { get; set; }
        private RepairsDatabaseSearch repairDS;
        public EditRepair(String _repairID)
        {
            RepairsDatabaseSearch.InitializeDB();
            InitializeComponent();
            repairID = _repairID;
        }

        private void EditRepair_Load(object sender, EventArgs e)
        {
            LoadRepairInfo();
            repairDS = new RepairsDatabaseSearch(repairID);
        }

        private void LoadRepairInfo()
        {
            repairDS = new RepairsDatabaseSearch(repairID);
            RepairIDTextBox.Text = repairID;
            repairTagNumberTextBox.Text = repairDS.repair.repairTag;
            repairCustomerNameTextBox.Text = repairDS.repair.repairCustName;
            repairCustomerPhoneNumberTextBox.Text = repairDS.repair.repairCustPhoneNumber;
            repairDescriptionTextBox.Text = repairDS.repair.repairDescription;
            repairModelTextBox.Text = repairDS.repair.repairModel;
            repairSerialTextBox.Text = repairDS.repair.repairSerial;
            repairNotesTextBox.Text = repairDS.repair.repairNotes;
        }

        private void EditInfo()
        {
            if (repairTagNumberTextBox.Text == "")
                repairTagNumberTextBox.Text = "null";
            if (repairCustomerNameTextBox.Text == "")
                repairCustomerNameTextBox.Text = "null";
            if (repairCustomerPhoneNumberTextBox.Text == "")
                repairCustomerPhoneNumberTextBox.Text = "null";
            if (repairDescriptionTextBox.Text == "")
                repairDescriptionTextBox.Text = "null";
            if (repairModelTextBox.Text == "")
                repairModelTextBox.Text = "null";
            if (repairSerialTextBox.Text == "")
                repairSerialTextBox.Text = "null";
            if (repairNotesTextBox.Text == "")
                repairNotesTextBox.Text = "null";

            repairDS.EditRepairInfo(RepairIDTextBox.Text,
               repairTagNumberTextBox.Text, 
               repairCustomerNameTextBox.Text, 
               repairCustomerPhoneNumberTextBox.Text, 
               repairDescriptionTextBox.Text,
               repairModelTextBox.Text, 
               repairSerialTextBox.Text, 
               repairNotesTextBox.Text);
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            EditInfo();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            EditInfo();
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

        private void repairTagNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (repairTagNumberTextBox.Text == "")
            {
                repairTagNumberTextBox.Text = "null";
            }
        }

        private void repairCustomerNameTextBox_Leave(object sender, EventArgs e)
        {
            if (repairCustomerNameTextBox.Text == "")
            {
                repairCustomerNameTextBox.Text = "null";
            }
        }

        private void repairCustomerPhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (repairCustomerPhoneNumberTextBox.Text == "")
            {
                repairCustomerPhoneNumberTextBox.Text = "null";
            }
        }

        private void repairDescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (repairDescriptionTextBox.Text == "")
            {
                repairDescriptionTextBox.Text = "null";
            }
        }

        private void repairModelTextBox_Leave(object sender, EventArgs e)
        {
            if (repairModelTextBox.Text == "")
            {
                repairModelTextBox.Text = "null";
            }
        }

        private void repairSerialTextBox_Leave(object sender, EventArgs e)
        {
            if (repairSerialTextBox.Text == "")
            {
                repairSerialTextBox.Text = "null";
            }
        }

        private void repairNotesTextBox_Leave(object sender, EventArgs e)
        {
            if (repairNotesTextBox.Text == "")
            {
                repairNotesTextBox.Text = "null";
            }
        }
    }
}
