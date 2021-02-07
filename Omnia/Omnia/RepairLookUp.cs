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
    }
}
