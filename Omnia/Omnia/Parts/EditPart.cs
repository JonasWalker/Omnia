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
    public partial class EditPart : Form
    {
        public String PartID { get; private set; }
        private PartsDatabaseSearch partDB;

        public EditPart(String _id)
        {
            PartsDatabaseSearch.InitializeDB();
            InitializeComponent();
            PartID = _id;
        }

        private void EditPart_Load(object sender, EventArgs e)
        {
            LoadPartInfo();
            partDB = new PartsDatabaseSearch(PartID);
        }
        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            EditPartInfo();
            this.Close();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            EditPartInfo();
        }

        private void LoadPartInfo()
        {
            PartsDatabaseSearch partsDS = new PartsDatabaseSearch(PartID);
            PartIDTextBox.Text = PartID;
            PartNumberTextBox.Text = partsDS.part.partNumber;
            PartDescriptionTextBox.Text = partsDS.part.partDescription;
            PartQuantityTextBox.Text = partsDS.part.partQty;
            MSRPTextBox.Text = partsDS.part.partMSRP;
            CostTextBox.Text = partsDS.part.partCost;
            NotesTextBox.Text = partsDS.part.partNote;
        }

        private void EditPartInfo()
        {
            if (PartNumberTextBox.Text == "")
                PartNumberTextBox.Text = "null";
            if (PartDescriptionTextBox.Text == "")
                PartDescriptionTextBox.Text = "null";
            if (PartQuantityTextBox.Text == "")
                PartQuantityTextBox.Text = "0.0";
            if (MSRPTextBox.Text == "")
                MSRPTextBox.Text = "0.00";
            if (CostTextBox.Text == "")
                CostTextBox.Text = "0.00";
            if (NotesTextBox.Text == "")
                NotesTextBox.Text = "null";

            partDB.EditPartInfo(PartID,
                PartNumberTextBox.Text,
                PartDescriptionTextBox.Text,
                PartQuantityTextBox.Text,
                MSRPTextBox.Text,
                CostTextBox.Text,
                NotesTextBox.Text);
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
        private void PartNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (PartNumberTextBox.Text == "")
            {
                PartNumberTextBox.Text = "null";
            }
        }
        private void PartDescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (PartDescriptionTextBox.Text == "")
            {
                PartDescriptionTextBox.Text = "null";
            }
        }

        private void PartQuantityTextBox_Leave(object sender, EventArgs e)
        {
            if (PartQuantityTextBox.Text != "")
            {
                PartQuantityTextBox.Text = Convert.ToDouble(PartQuantityTextBox.Text).ToString("0.0");
            }
            else
            {
                PartQuantityTextBox.Text = "0.0";
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
        private void NotesTextBox_Leave(object sender, EventArgs e)
        {
            if (NotesTextBox.Text == "")
            {
                NotesTextBox.Text = "null";
            }   
        }
    }
}
