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
    public partial class PartsLookUp : Form
    {
        public PartsLookUp()
        {
            InitializeComponent();
            PartsDatabaseSearch.InitializeDB();
            LoadAll();

        }
        private void PartsLookUp_Load(object sender, EventArgs e)
        {
            
        }
          
        private void LoadAll()
        {
            List<PartsDatabaseSearch> parts = PartsDatabaseSearch.GetAllParts();

            listView1.Items.Clear();
            
            foreach( PartsDatabaseSearch p in parts)
            {
                ListViewItem item = new ListViewItem(new String[] { p.idparts, p.partNumber, p.partDescription, p.partQty, p.partMSRP, p.partCost, p.partNote });
                item.Tag = p;
                listView1.Items.Add(item);
            }
        }

        private void AllParts_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            partNumberBox.Text = "";
            partDescriptionBox.Text = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<PartsDatabaseSearch> parts = 
                PartsDatabaseSearch.GetSearchedParts(partNumberBox.Text, partDescriptionBox.Text);

            listView1.Items.Clear();
              
            foreach (PartsDatabaseSearch p in parts)
            {
                ListViewItem item = new ListViewItem(new String[] { p.idparts, p.partNumber, p.partDescription, p.partQty, p.partMSRP, p.partCost, p.partNote });
                item.Tag = p;
                listView1.Items.Add(item);
            }

        }
    }
}
