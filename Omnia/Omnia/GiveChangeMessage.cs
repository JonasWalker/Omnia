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
    public partial class GiveChangeMessage : Form
    {
        public GiveChangeMessage(String text)
        {
            InitializeComponent();
            ChangeText.Text = text;
        }

        private void GiveChangeMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
