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
    public partial class EditCustomer : Form
    {
        private static String customerID { get; set; }
        private CustomersDatabaseSearch customersDS;
        public EditCustomer(String _customerID)
        {
            CustomersDatabaseSearch.InitializeDB();
            InitializeComponent();
            customerID = _customerID;
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerInfo();
            customersDS = new CustomersDatabaseSearch(customerID);
        }

        private void LoadCustomerInfo()
        {
            customersDS = new CustomersDatabaseSearch(customerID);
            CustomerIDTextBox.Text = customersDS.customer.customerID;
            customerNameTextBox.Text = customersDS.customer.customerName;
            customerPhoneNumberTextBox.Text = customersDS.customer.customerPhoneNumber;
            customerAltPhoneNumberTextBox.Text = customersDS.customer.customerAltPhoneNumber;
            customerAddressTextBox.Text = customersDS.customer.customerAddress;
            customerZIPTextBox.Text = customersDS.customer.customerZIPCode;
            customerStateTextBox.Text = customersDS.customer.customerState;
            customerNotesTextBox.Text = customersDS.customer.customerNotes;
        }

        private void EditInfo()
        {
            if (customerNameTextBox.Text == "")
                customerNameTextBox.Text = "null";
            if (customerPhoneNumberTextBox.Text == "")
                customerPhoneNumberTextBox.Text = "null";
            if (customerAltPhoneNumberTextBox.Text == "")
                customerAltPhoneNumberTextBox.Text = "null";
            if (customerAddressTextBox.Text == "")
                customerAddressTextBox.Text = "null";
            if (customerZIPTextBox.Text == "")
                customerZIPTextBox.Text = "null";
            if (customerStateTextBox.Text == "")
                customerStateTextBox.Text = "null";
            if (customerNotesTextBox.Text == "")
                customerNotesTextBox.Text = "null";

            customersDS.EditCustomerInfo(CustomerIDTextBox.Text, 
                customerNameTextBox.Text, 
                customerPhoneNumberTextBox.Text, 
                customerAltPhoneNumberTextBox.Text, 
                customerAddressTextBox.Text, 
                customerZIPTextBox.Text, 
                customerStateTextBox.Text, 
                customerNotesTextBox.Text);
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
            customerNameTextBox.Text = "";
            customerPhoneNumberTextBox.Text = "";
            customerAltPhoneNumberTextBox.Text = "";
            customerAddressTextBox.Text = "";
            customerZIPTextBox.Text = "";
            customerStateTextBox.Text = "";
            customerNotesTextBox.Text = "";
        }

        private void customerNameTextBox_Leave(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text == "")
            {
                customerNameTextBox.Text = "null";
            }
        }

        private void customerPhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (customerPhoneNumberTextBox.Text == "")
            {
                customerPhoneNumberTextBox.Text = "null";
            }
        }

        private void customerAltPhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (customerAltPhoneNumberTextBox.Text == "")
            {
                customerAltPhoneNumberTextBox.Text = "null";
            }
        }

        private void customerAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (customerAddressTextBox.Text == "")
            {
                customerAddressTextBox.Text = "null";
            }
        }

        private void customerZIPTextBox_Leave(object sender, EventArgs e)
        {
            if (customerZIPTextBox.Text == "")
            {
                customerZIPTextBox.Text = "null";
            }
        }

        private void customerStateTextBox_Leave(object sender, EventArgs e)
        {
            if (customerStateTextBox.Text == "")
            {
                customerStateTextBox.Text = "null";
            }
        }

        private void customerNotesTextBox_Leave(object sender, EventArgs e)
        {
            if (customerNotesTextBox.Text == "")
            {
                customerNotesTextBox.Text = "null";
            }
        }
    }
}