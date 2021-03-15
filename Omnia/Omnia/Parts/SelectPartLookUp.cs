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
    public partial class SelectPartLookUp : Form
    {        
        public SelectedPart selectedPart;

        public struct SelectedPart
        {
            public String idparts;
            public String partNumber;
            public String partDescription;
            public String partQty;
            public String partMSRP;
            public String partCost;
            public String partNote;

            public SelectedPart(String _idparts = null, String _partNumber = null, String _partDescription = null,
                String _partQty = null, String _partMSRP = null, String _partCost = null, String _partNote = null)
            {
                idparts = _idparts;
                partNumber = _partNumber;
                partDescription = _partDescription;
                partQty = _partQty;
                partMSRP = _partMSRP;
                partCost = _partCost;
                partNote = _partNote;
            }
        }

        public SelectPartLookUp()
        {
            InitializeComponent();
            PartsDatabaseSearch.InitializeDB();
        }
        public SelectPartLookUp(String text = null, String text2 = null)
        {
            InitializeComponent();
            PartsDatabaseSearch.InitializeDB();
            PartNumberTextBox.Text = text;
            PartDescriptionTextBox.Text = text2;
            SearchForParts();
        }

        private void SelectPartLookUp_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForParts();
        }

        private void SearchForParts()
        {
            List<PartsDatabaseSearch> parts =
                PartsDatabaseSearch.GetSearchedParts(PartNumberTextBox.Text, PartDescriptionTextBox.Text);

            PartsListView.Items.Clear();

            foreach (PartsDatabaseSearch p in parts)
            {
                ListViewItem item = new ListViewItem(new String[] { p.idparts, p.partNumber, p.partDescription, p.partQty, p.partMSRP, p.partCost, p.partNote });
                item.Tag = p;
                PartsListView.Items.Add(item);
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if(PartsListView.SelectedItems.Count == 0)
            {
                this.Hide();
            }
            else
            {
                selectedPart = new SelectedPart(PartsListView.SelectedItems[0].SubItems[0].Text,
                PartsListView.SelectedItems[0].SubItems[1].Text,
                PartsListView.SelectedItems[0].SubItems[2].Text,
                PartsListView.SelectedItems[0].SubItems[3].Text,
                PartsListView.SelectedItems[0].SubItems[4].Text,
                PartsListView.SelectedItems[0].SubItems[5].Text,
                PartsListView.SelectedItems[0].SubItems[6].Text);

                this.Hide();
            }
        }
    }
}
