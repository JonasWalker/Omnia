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

            ListViewItem item = new ListViewItem(new String[] {selectPartLookUp.selectedPart.idparts, 
                selectPartLookUp.selectedPart.partNumber, 
                selectPartLookUp.selectedPart.partDescription,
                selectPartLookUp.selectedPart.partQty, 
                selectPartLookUp.selectedPart.partMSRP, 
                selectPartLookUp.selectedPart.partCost, 
                selectPartLookUp.selectedPart.partNote});

            PartsListView.Items.Add(item);

            selectPartLookUp.Close();

            PartNumberTextBox.Text = "";
            PartDescriptionTextBox.Text = "";
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            PartsListView.Items.Clear();
            PartNumberTextBox.Text = "";
            PartDescriptionTextBox.Text = "";
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            DeleteMessage message = new DeleteMessage("Are you sure you want to delete the selected part(s)?");
            message.ShowDialog();
            if (message.DialogResult == DialogResult.OK)
            {
                int temp = (PartsListView.Items.Count) - (PartsListView.SelectedItems.Count);
                for (int i = 0; i < PartsListView.SelectedItems.Count; i++)
                {
                    PartsListView.Items.Remove(PartsListView.SelectedItems[i]);
                    //PartsListView.Items.RemoveAt(PartsListView.SelectedIndices[i]);
                }
            }
        }

        /*
        DeleteMessage message = new DeleteMessage("Are you sure you want to delete the selected part(s)?");
        message.ShowDialog();
        if (message.DialogResult == DialogResult.OK)
        {
            ////////////////////////////////////////////////////////////////
            DeletePart deletePart = new DeletePart();
            for (int i = 0; i < PartsListView.SelectedItems.Count; i++)
            {
                String temp = PartsListView.SelectedItems[i].SubItems[0].Text;
                deletePart.DeleteSelectedParts(temp);
            }
            LoadAll();
            ////////////////////////////////////////////////////////////////
        }
        */
    }
}
