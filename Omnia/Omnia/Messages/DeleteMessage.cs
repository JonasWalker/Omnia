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
    public partial class DeleteMessage : Form
    {
        public DeleteMessage(String message)
        {
            InitializeComponent();
            DeleteText.Text = message;
        }
    }
}
