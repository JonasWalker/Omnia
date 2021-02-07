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
                    p.customerAltPhoneNumber, p.customerAddress, p.customerZIPCode, p.customerState });
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
                    c.customerAltPhoneNumber, c.customerAddress, c.customerZIPCode, c.customerState});
                item.Tag = c;
                CustomerListView.Items.Add(item);
            }
        }
    }
}
