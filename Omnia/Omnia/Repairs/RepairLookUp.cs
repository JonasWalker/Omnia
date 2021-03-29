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
    public partial class RepairLookUp : Form
    {
        public RepairLookUp()
        {
            InitializeComponent();
            RepairsDatabaseSearch.InitializeDB();
            LoadAll();
        }

        private void AllRepairs_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void LoadAll()
        {
            List<RepairsDatabaseSearch> repairs = RepairsDatabaseSearch.GetAllRepairs();

            RepairListView.Items.Clear();

            foreach(RepairsDatabaseSearch r in repairs)
            {
                ListViewItem item = new ListViewItem(new String[] { r.repairID, r.repairTag, r.repairCustName, r.repairCustPhoneNumber, r.repairDescription, r.repairModel, r.repairSerial, r.repairNotes });
                item.Tag = r;
                RepairListView.Items.Add(item);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            RepairListView.Items.Clear();
            NameTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            TagNumberTextBox.Text = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<RepairsDatabaseSearch> repairs =
                RepairsDatabaseSearch.GetSearchedRepairs(NameTextBox.Text, PhoneNumberTextBox.Text, TagNumberTextBox.Text);

            RepairListView.Items.Clear();

            foreach (RepairsDatabaseSearch r in repairs)
            {
                ListViewItem item = new ListViewItem(new String[] { r.repairID, r.repairTag, r.repairCustName, r.repairCustPhoneNumber, r.repairDescription, r.repairModel, r.repairSerial, r.repairNotes });
                item.Tag = r;
                RepairListView.Items.Add(item);
            }
        }

        private void RepairLookUp_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
            EmployeeNameLabel.Text = LoginDatabaseSearch.selectedUser.firstName + " " + LoginDatabaseSearch.selectedUser.lastName;
        }

        private void CreateRepairButton_Click(object sender, EventArgs e)
        {
            NewRepair newRepair = new NewRepair();
            newRepair.ShowDialog();
            LoadAll();
        }

        private void DeleteRepairBtton_Click(object sender, EventArgs e)
        {
            DeleteMessage message = new DeleteMessage("Are you sure you want to delete the selected customer(s)?");
            message.ShowDialog();
            if (message.DialogResult == DialogResult.OK)
            {
                DeleteRepair deleteRepair = new DeleteRepair();
                for (int i = 0; i < RepairListView.SelectedItems.Count; i++)
                {
                    String temp = RepairListView.SelectedItems[i].SubItems[0].Text;
                    deleteRepair.DeleteSelectedParts(temp);
                }
                LoadAll();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm tt");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(RepairListView.SelectedItems.Count == 1)
            {
                EditRepair editRepair = new EditRepair(RepairListView.SelectedItems[0].SubItems[0].Text);
                editRepair.ShowDialog();
            }
            LoadAll();
        }
    }
}
