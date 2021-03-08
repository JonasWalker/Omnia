﻿using System;
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
        public PartsLookUp(String text = null, String text2 = null)
        {
            InitializeComponent();
            PartsDatabaseSearch.InitializeDB();
            PartNumberTextBox.Text = text;
            PartDescriptionTextBox.Text = text2;
            SearchForPart();
        }

        private void PartsLookUp_Load(object sender, EventArgs e)
        {
            
        }
          
        private void LoadAll()
        {
            List<PartsDatabaseSearch> parts = PartsDatabaseSearch.GetAllParts();

            PartsListView.Items.Clear();
            
            foreach( PartsDatabaseSearch p in parts)
            {
                ListViewItem item = new ListViewItem(new String[] { p.idparts, p.partNumber, p.partDescription, p.partQty, p.partMSRP, p.partCost, p.partNote });
                item.Tag = p;
                PartsListView.Items.Add(item);
            }
        }

        private void AllParts_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PartsListView.Items.Clear();
            PartNumberTextBox.Text = "";
            PartDescriptionTextBox.Text = "";
        }

        private void Search_Click(object sender, EventArgs e)
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

        private void SearchForPart()
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

        private void CreatePartButton_Click(object sender, EventArgs e)
        {
            NewPart newPart = new NewPart();
            newPart.ShowDialog();
            if(newPart.DialogResult == DialogResult.OK)
            {
                LoadAll();
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
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
        }
    }
}
