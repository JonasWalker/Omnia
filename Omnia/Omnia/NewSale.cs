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

        private void Search_Click(object sender, EventArgs e)
        {
            PartsLookUp partsLookUp = new PartsLookUp(PartNumberTextBox.Text, PartDescriptionTextBox.Text);
            partsLookUp.ShowDialog();
        }
    }
}
