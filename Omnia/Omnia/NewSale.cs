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
    public partial class NewSale : Form
    {

        public double grandTotal = 0;
        public NewSale()
        {
            InitializeComponent();
        }

        private void CustomerSearchButton_Click(object sender, EventArgs e)
        {
            SelectCustomerLookUp selectCustomerLookUp = new SelectCustomerLookUp(CustomerNameTextBox.Text, CustomerPhoneNumberTextBox.Text);
            selectCustomerLookUp.ShowDialog();
            CustomerNameTextBox.Text = selectCustomerLookUp.selectedCustomer.customerName;
            CustomerPhoneNumberTextBox.Text = selectCustomerLookUp.selectedCustomer.customerPhoneNumber;
            selectCustomerLookUp.Close();
        }

        private void PartSearchButton_Click(object sender, EventArgs e)
        {
            SelectPartLookUp selectPartLookUp = new SelectPartLookUp(PartNumberTextBox.Text, PartDescriptionTextBox.Text);
            selectPartLookUp.ShowDialog();

            if(selectPartLookUp.selectedPart.idparts != null)
            {
                ListViewItem item = new ListViewItem(new String[] {selectPartLookUp.selectedPart.idparts,
                selectPartLookUp.selectedPart.partNumber,
                selectPartLookUp.selectedPart.partDescription,
                selectPartLookUp.selectedPart.partQty,
                selectPartLookUp.selectedPart.partMSRP,  
                selectPartLookUp.selectedPart.partCost,
                selectPartLookUp.selectedPart.partNote
            });

                PartsListView.Items.Add(item);
            }

            selectPartLookUp.Close();

            PartNumberTextBox.Text = "";
            PartDescriptionTextBox.Text = "";
            UpdateTextBoxes();
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            PartsListView.Items.Clear();
            PartNumberTextBox.Text = "";
            PartDescriptionTextBox.Text = "";
            UpdateTextBoxes();
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            DeleteMessage message = new DeleteMessage("Are you sure you want to delete the selected part(s)?");
            message.ShowDialog();
            if (message.DialogResult == DialogResult.OK)
            {
                foreach (ListView listview in this.Controls.OfType<Control>().
                Where(c => c.GetType() == typeof(ListView)))
                {
                    foreach (ListViewItem listitem in listview.SelectedItems)
                        listitem.Remove();
                }
            }
            UpdateTextBoxes();
        }

        private void TotalOutButton_Click(object sender, EventArgs e)
        {
            PaymentScreen paymentScreen = new PaymentScreen(grandTotal);
            paymentScreen.ShowDialog();
            this.Close();
        }
        private void UpdateTextBoxes()
        {
            double tax = .08275;
            double totalItems = 0;
            double totalCost = 0;
            double totalTax = 0;
            double discount = 0;

            for (int i = 0; i < PartsListView.Items.Count; i++)
            {
                totalItems += Convert.ToDouble(PartsListView.Items[i].SubItems[3].Text);
                totalCost += Convert.ToDouble(PartsListView.Items[i].SubItems[5].Text);
            }

            totalTax = totalCost * tax;
            grandTotal = totalCost + totalTax;

            TotalItemsTextBox.Text = Convert.ToString(totalItems);
            TotalCostTextBox.Text = totalCost.ToString("0.00");
            TotalTaxTextBox.Text = totalTax.ToString("0.00");
            if(DiscountTextBox.Text != "0%")
            {
                discount = grandTotal * (Convert.ToDouble(DiscountTextBox.Text) / 100);
                grandTotal = grandTotal - discount;
                GrandTotalTextBox.Text = grandTotal.ToString("0.00");
            }
            GrandTotalTextBox.Text = grandTotal.ToString("0.00");

        }

        private void DiscountTextBox_Leave(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        private void NewSale_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
            EmployeeNameLabel.Text = LoginDatabaseSearch.selectedUser.firstName + " " + LoginDatabaseSearch.selectedUser.lastName;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm tt");
        }
    }
}
