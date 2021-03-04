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
            while(UsernameLabel.Text == "" || PasswordLabel.Text == "")
            {
                if (UsernameLabel.Text != "" && PasswordLabel.Text == "")
                {
                    ErrorMessage errorMessage = new ErrorMessage("The username was left blank. Please enter a username.");
                    errorMessage.ShowDialog();
                    return;
                }
                if (UsernameLabel.Text == "" && PasswordLabel.Text != "")
                {
                    ErrorMessage errorMessage = new ErrorMessage("The password was left blank. Please enter a password.");
                    errorMessage.ShowDialog();
                    return;
                }
                if (UsernameLabel.Text == "" && PasswordLabel.Text == "")
                {
                    ErrorMessage errorMessage = new ErrorMessage("The username and password was left blank. Please enter a username and password.");
                    errorMessage.ShowDialog();
                    return;
                }
            }


            int code = LoginDatabaseSearch.Login(UsernameLabel.Text, PasswordLabel.Text);

            if(code == 0)
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                this.Close();
            }
            if (code == 1)
            {
                ErrorMessage errorMessage = new ErrorMessage("Incorrect username. Try Again.");
                errorMessage.ShowDialog();
            }
            if (code == 2)
            {
                ErrorMessage errorMessage = new ErrorMessage("Incorrect password. Try Again.");
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
