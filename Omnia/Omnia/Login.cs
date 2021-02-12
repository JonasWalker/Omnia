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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginDatabaseSearch.InitializeDB();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Code 0 = username and password are good
            //Code 1 = both username and password are null
            //Code 2 = password is null
            //Code 3 = username is null
            //Code 4 = something went wrong
            //Code 5 = ?
            int code = LoginDatabaseSearch.Login(UsernameLabel.Text, PasswordLabel.Text);
            if(code == 0)
            {
                Home home = new Home();
                home.ShowDialog();
            }
            if(code == 1)
            {
                ErrorMessage errorMessage = new ErrorMessage("Please enter a username and password.");
                errorMessage.ShowDialog();
            }
            if (code == 2)
            {
                ErrorMessage errorMessage = new ErrorMessage("Either the username or password was left blank. Please enter a username and password.");
                errorMessage.ShowDialog();
            }
            if (code == 3)
            {
                ErrorMessage errorMessage = new ErrorMessage("Either the username or password was left blank. Please enter a username and password.");
                errorMessage.ShowDialog();
            }
            if (code == 4)
            {
                ErrorMessage errorMessage = new ErrorMessage("Unknown Error. Try Again.");
                errorMessage.ShowDialog();
            }
        }
    }
}
