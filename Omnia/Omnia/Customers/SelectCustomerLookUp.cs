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
    public partial class SelectCustomerLookUp : Form
    {
        public SelectedCustomer selectedCustomer;

        public struct SelectedCustomer
        {
            public String idcustomer;
            public String customerName;
            public String customerPhoneNumber;
            public String customerAltPhoneNumber;
            public String customerAddress;
            public String customerZIPCode;
            public String customerState;

            public SelectedCustomer(String _idcustomer = null, String _customerName = null, String _customerPhoneNumber = null,
                String _customerAltPhoneNumber = null, String _customerAddress = null, String _customerZIPCode = null, String _customerState = null)
            {
                idcustomer = _idcustomer;
                customerName = _customerName;
                customerPhoneNumber = _customerPhoneNumber;
                customerAltPhoneNumber = _customerAltPhoneNumber;
                customerAddress = _customerAddress;
                customerZIPCode = _customerZIPCode;
                customerState = _customerState;
            }
        }

        public SelectCustomerLookUp()
        {
            InitializeComponent();
            PartsDatabaseSearch.InitializeDB();
        }

        public SelectCustomerLookUp(String text = null, String text2 = null)
        {
            InitializeComponent();
            CustomersDatabaseSearch.InitializeDB();
            CustomerNameTextBox.Text = text;
            CustomerPhoneNumberTextBox.Text = text2;
            SearchForCustomer();
        }

        private void SelectCustomerLookUp_Load(object sender, EventArgs e)
        {

        }
        private void SearchForCustomer()
        {
            List<CustomersDatabaseSearch> customers =
                CustomersDatabaseSearch.GetSearchedCustomers(CustomerNameTextBox.Text, CustomerPhoneNumberTextBox.Text);

            CustomerListView.Items.Clear();

            foreach (CustomersDatabaseSearch c in customers)
            {
                ListViewItem item = new ListViewItem(new String[] {c.idcustomers, c.customerName, c.customerPhoneNumber,
                    c.customerAltPhoneNumber, c.customerAddress, c.customerZIPCode, c.customerState});
                item.Tag = c;
                CustomerListView.Items.Add(item);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchForCustomer();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CustomerListView.Items.Clear();
            CustomerNameTextBox.Text = "";
            CustomerPhoneNumberTextBox.Text = "";
        }

        public void SelectButton_Click(object sender, EventArgs e)
        {
            if(CustomerListView.SelectedItems.Count >= 1)
            {
                selectedCustomer = new SelectedCustomer(CustomerListView.SelectedItems[0].SubItems[0].Text,
              CustomerListView.SelectedItems[0].SubItems[1].Text,
              CustomerListView.SelectedItems[0].SubItems[2].Text,
              CustomerListView.SelectedItems[0].SubItems[3].Text,
              CustomerListView.SelectedItems[0].SubItems[4].Text,
              CustomerListView.SelectedItems[0].SubItems[5].Text,
              CustomerListView.SelectedItems[0].SubItems[6].Text);
            }
            this.Hide();
        }

        private void AllCustomersButton_Click(object sender, EventArgs e)
        {
            SearchForCustomer();
        }
    }
}
