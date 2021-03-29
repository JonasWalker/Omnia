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
    public partial class CustomerLookUp : Form
    {
        public CustomerLookUp()
        {
            InitializeComponent();
            CustomersDatabaseSearch.InitializeDB();
            LoadAll();
        }

        private void CustomerLookUp_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
            EmployeeNameLabel.Text = LoginDatabaseSearch.selectedUser.firstName + " " + LoginDatabaseSearch.selectedUser.lastName;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CustomerListView.Items.Clear();
            NameBox.Text = "";
            PhoneNumberBox.Text = "";
        }

        private void AllCustomersButton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void LoadAll()
        {
            List<CustomersDatabaseSearch> customers = CustomersDatabaseSearch.GetAllCustomers();

            CustomerListView.Items.Clear();

            foreach (CustomersDatabaseSearch p in customers)
            {
                ListViewItem item = new ListViewItem(new String[] { p.idcustomers, p.customerName, p.customerPhoneNumber, 
                    p.customerAltPhoneNumber, p.customerAddress, p.customerZIPCode, p.customerState, p.customerNotes });
                item.Tag = p;
                CustomerListView.Items.Add(item);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<CustomersDatabaseSearch> customers = 
                CustomersDatabaseSearch.GetSearchedCustomers(NameBox.Text, PhoneNumberBox.Text);

            CustomerListView.Items.Clear();

            foreach (CustomersDatabaseSearch c in  customers)
            {
                ListViewItem item = new ListViewItem(new String[] {c.idcustomers, c.customerName, c.customerPhoneNumber,
                    c.customerAltPhoneNumber, c.customerAddress, c.customerZIPCode, c.customerState,c.customerNotes});
                item.Tag = c;
                CustomerListView.Items.Add(item);
            }
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.ShowDialog();
            LoadAll();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            DeleteMessage message = new DeleteMessage("Are you sure you want to delete the selected customer(s)?");
            message.ShowDialog();
            if (message.DialogResult == DialogResult.OK)
            {
                DeleteCustomer deleteCustomer = new DeleteCustomer();
                for (int i = 0; i < CustomerListView.SelectedItems.Count; i++)
                {
                    String temp = CustomerListView.SelectedItems[i].SubItems[0].Text;
                    deleteCustomer.DeleteSelectedParts(temp);
                }
                LoadAll();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm tt");
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if(CustomerListView.SelectedItems.Count == 1)
            {
                EditCustomer editCustomer = new EditCustomer(CustomerListView.SelectedItems[0].SubItems[0].Text);
                editCustomer.ShowDialog();
            }
            LoadAll();
        }
    }
}
