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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerLookUp customerLookUp = new CustomerLookUp();
            customerLookUp.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RepairLookUp repairLookUp = new RepairLookUp();
            repairLookUp.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reports reportsLookUp = new Reports(); 
            reportsLookUp.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Timesheets timesheets = new Timesheets();
            timesheets.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PartsLookUp partsLookUp = new PartsLookUp();
            partsLookUp.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
