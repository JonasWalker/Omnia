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
    public partial class Timesheets : Form
    {
        public double TotalHours { get; set; }
        
        public Timesheets()
        {
            InitializeComponent();
            TimesheetDatabaseSearch.InitializeDB();
        }

        private void Timesheets_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
            NameLabel.Text = LoginDatabaseSearch.selectedUser.firstName + " " + LoginDatabaseSearch.selectedUser.lastName;
            loadTimeSheet();
            //ClearTextBoxes();
            DoTheMathTextBoxes();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm tt");
        }

        public void ClearTextBoxes()
        {
            SundayHoursTextBox.Text = "0.0";
            MondayHoursTextBox.Text = "0.0";
            TuesdayHoursTextBox.Text = "0.0";
            WednesdayHoursTextBox.Text = "0.0";
            ThrusdayHoursTextBox.Text = "0.0";
            FridayHoursTextBox.Text = "0.0";
            SaturdayHoursTextBox.Text = "0.0";
            TotalHours = 0.0;
            TotalHoursTextBox.Text = "0.0";
        }

        public void loadTimeSheet()
        {
            TimesheetDatabaseSearch.UserTimesheet timesheet = TimesheetDatabaseSearch.getTimesheet();

            SundayHoursTextBox.Text = timesheet.sundayHours;
            MondayHoursTextBox.Text = timesheet.mondayHours;
            TuesdayHoursTextBox.Text = timesheet.tuesdayHours;
            WednesdayHoursTextBox.Text = timesheet.wednesdayHours;
            ThrusdayHoursTextBox.Text = timesheet.thrusdayHours;
            FridayHoursTextBox.Text = timesheet.fridayHours;
            SaturdayHoursTextBox.Text = timesheet.saturdayHours;
        }


        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            TimesheetDatabaseSearch timesheetDatabase = new TimesheetDatabaseSearch();
            timesheetDatabase.UpdateTimesheet(SundayHoursTextBox.Text, MondayHoursTextBox.Text, TuesdayHoursTextBox.Text, WednesdayHoursTextBox.Text, 
                ThrusdayHoursTextBox.Text, FridayHoursTextBox.Text, SaturdayHoursTextBox.Text);
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TimesheetDatabaseSearch timesheetDatabase = new TimesheetDatabaseSearch();
            timesheetDatabase.UpdateTimesheet(SundayHoursTextBox.Text, MondayHoursTextBox.Text, TuesdayHoursTextBox.Text, WednesdayHoursTextBox.Text,
                ThrusdayHoursTextBox.Text, FridayHoursTextBox.Text, SaturdayHoursTextBox.Text);
        }

        private void DoTheMathTextBoxes()
        {
            TotalHours = 0;
            TotalHours += Convert.ToDouble(SundayHoursTextBox.Text);
            TotalHours += Convert.ToDouble(MondayHoursTextBox.Text);
            TotalHours += Convert.ToDouble(TuesdayHoursTextBox.Text);
            TotalHours += Convert.ToDouble(WednesdayHoursTextBox.Text);
            TotalHours += Convert.ToDouble(ThrusdayHoursTextBox.Text);
            TotalHours += Convert.ToDouble(FridayHoursTextBox.Text);
            TotalHours += Convert.ToDouble(SaturdayHoursTextBox.Text);

            TotalHoursTextBox.Text = TotalHours.ToString("0.0");

        }
        private void ClearListButton_Click(object sender, EventArgs e)
        {
            SundayHoursTextBox.Text = "0.0";
            MondayHoursTextBox.Text = "0.0";
            TuesdayHoursTextBox.Text = "0.0";
            WednesdayHoursTextBox.Text = "0.0";
            ThrusdayHoursTextBox.Text = "0.0";
            FridayHoursTextBox.Text = "0.0";
            SaturdayHoursTextBox.Text = "0.0";
            TotalHours = 0.0;
            TotalHoursTextBox.Text = "0.0";
        }

        private void TotalItemsTextBox_Leave(object sender, EventArgs e)
        {
            if (SundayHoursTextBox.Text != "")
            {
                SundayHoursTextBox.Text = Convert.ToDouble(SundayHoursTextBox.Text).ToString("0.0");
                DoTheMathTextBoxes();
            }
            else
            {
                SundayHoursTextBox.Text = "0.0";
            }
        }

        private void MondayHoursTextBox_Leave(object sender, EventArgs e)
        {
            if (MondayHoursTextBox.Text != "")
            {
                MondayHoursTextBox.Text = Convert.ToDouble(MondayHoursTextBox.Text).ToString("0.0");
                DoTheMathTextBoxes();
            }
            else
            {
                MondayHoursTextBox.Text = "0.0";
            }
        }

        private void TuesdayHoursTextBox_Leave(object sender, EventArgs e)
        {
            if (TuesdayHoursTextBox.Text != "")
            {
                TuesdayHoursTextBox.Text = Convert.ToDouble(TuesdayHoursTextBox.Text).ToString("0.0");
                DoTheMathTextBoxes();
            }
            else
            {
                TuesdayHoursTextBox.Text = "0.0";
            }
        }

        private void WednesdayHoursTextBox_Leave(object sender, EventArgs e)
        {
            if (WednesdayHoursTextBox.Text != "")
            {
                WednesdayHoursTextBox.Text = Convert.ToDouble(WednesdayHoursTextBox.Text).ToString("0.0");
                DoTheMathTextBoxes();
            }
            else
            {
                WednesdayHoursTextBox.Text = "0.0";
            }
        }

        private void ThrusdayHoursTextBox_Leave(object sender, EventArgs e)
        {
            if (ThrusdayHoursTextBox.Text != "")
            {
                ThrusdayHoursTextBox.Text = Convert.ToDouble(ThrusdayHoursTextBox.Text).ToString("0.0");
                DoTheMathTextBoxes();
            }
            else
            {
                ThrusdayHoursTextBox.Text = "0.0";
            }
        }

        private void FridayHoursTextBox_Leave(object sender, EventArgs e)
        {
            if (FridayHoursTextBox.Text != "")
            {
                FridayHoursTextBox.Text = Convert.ToDouble(FridayHoursTextBox.Text).ToString("0.0");
                DoTheMathTextBoxes();
            }
            else
            {
                FridayHoursTextBox.Text = "0.0";
            }
        }

        private void SaturdayHoursTextBox_Leave(object sender, EventArgs e)
        {
            if (SaturdayHoursTextBox.Text != "")
            {
                SaturdayHoursTextBox.Text = Convert.ToDouble(SaturdayHoursTextBox.Text).ToString("0.0");
                DoTheMathTextBoxes();
            }
            else
            {
                SaturdayHoursTextBox.Text = "0.0";
            }
        }

        private void SundayHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MondayHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TuesdayHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void WednesdayHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ThrusdayHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FridayHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SaturdayHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
