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
    public partial class PaymentScreen : Form
    {
        public double grandTotal { get; private set; }
        public double addedAmount { get; private set; }
        public PaymentScreen()
        {
            InitializeComponent();
        }

        public PaymentScreen(double _grandTotal)
        {
            InitializeComponent();
            TotalLabel.Text = _grandTotal.ToString("0.00");
            grandTotal = _grandTotal;
        }

        private void PaymentScreen_Load(object sender, EventArgs e)
        {

        }
        private void DoTheMathTextBoxes()
        {
            addedAmount = Convert.ToDouble(CashTextBox.Text) + Convert.ToDouble(CreditCardTextBox.Text) +
                Convert.ToDouble(DebitCardTextBox.Text) + Convert.ToDouble(CheckTextBox.Text);

            TotalLabel.Text = (grandTotal - addedAmount).ToString("0.00");            
        }

        private void TotalOutButton_Click(object sender, EventArgs e)
        {
            DoTheMathTextBoxes();
            GiveChangeMessage giveChangeMessage = new GiveChangeMessage("Change: $" + (addedAmount - grandTotal).ToString("0.00"));
            giveChangeMessage.ShowDialog();
            if(giveChangeMessage.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void CashTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreditCardTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DebitCardTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CheckTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CashTextBox_Leave(object sender, EventArgs e)
        {
            if (CashTextBox.Text != "")
            {
                CashTextBox.Text = Convert.ToDouble(CashTextBox.Text).ToString("0.00");
                DoTheMathTextBoxes();
            }
            else
            {
                CashTextBox.Text = "0.00";
            }
        }

        private void CreditCardTextBox_Leave(object sender, EventArgs e)
        {
            if (CreditCardTextBox.Text != "")
            {
                CreditCardTextBox.Text = Convert.ToDouble(CreditCardTextBox.Text).ToString("0.00");
                DoTheMathTextBoxes();
            }
            else
            {
                CreditCardTextBox.Text = "0.00";
            }

        }

        private void DebitCardTextBox_Leave(object sender, EventArgs e)
        {
            if (DebitCardTextBox.Text != "")
            {
                DebitCardTextBox.Text = Convert.ToDouble(DebitCardTextBox.Text).ToString("0.00");
                DoTheMathTextBoxes();
            }
            else
            {
                DebitCardTextBox.Text = "0.00";
            }
        }

        private void CheckTextBox_Leave(object sender, EventArgs e)
        {
            if (CheckTextBox.Text != "")
            {
                CheckTextBox.Text = Convert.ToDouble(CheckTextBox.Text).ToString("0.00");
                DoTheMathTextBoxes();
            }
            else
            {
                CheckTextBox.Text = "0.00";
            }
        }

        private void CreditCardTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
