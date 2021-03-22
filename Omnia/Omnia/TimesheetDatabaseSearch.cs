using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Omnia
{
    class TimesheetDatabaseSearch
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "omnia";
        private const String UID = "JonasWalker";
        private const String PASSWORD = "jonas1999";
        private static MySqlConnection dbConn;

        public String employee { get; private set; }
        public String payRate { get; private set; }
        public String sunday { get; private set; }
        public String monday { get; private set; }
        public String tuesday { get; private set; }
        public String wednesday { get; private set; }
        public String thrusday { get; private set; }
        public String friday { get; private set; }
        public String saturday { get; private set; }

        public static UserTimesheet userTimesheet;


        public struct UserTimesheet
        {
            public String ID;
            public String payRate;
            public String sundayHours;
            public String mondayHours;
            public String tuesdayHours;
            public String wednesdayHours;
            public String thrusdayHours;
            public String fridayHours;
            public String saturdayHours;

            public UserTimesheet(/*String _ID = null,*/ String _payRate = null, String _sundayHours = null, String _mondayHours = null, String _tuesdayHours = null, String _wednesdayHours = null,
                String _thrusdayHours = null, String _fridayHours = null, String _saturdayHours = null)
            {
                ID = LoginDatabaseSearch.selectedUser.ID;
                payRate = _payRate;
                sundayHours = _sundayHours;
                mondayHours = _mondayHours;
                tuesdayHours = _tuesdayHours;
                wednesdayHours = _wednesdayHours;
                thrusdayHours = _thrusdayHours;
                fridayHours = _fridayHours;
                saturdayHours = _saturdayHours;
            }
        }




        public TimesheetDatabaseSearch()
        {

        }

        private TimesheetDatabaseSearch(String _payRate, String _sunday, String _monday, String _tuesday, String _wednesday, String _thrusday, String _friday, String _saturday)
        {
            payRate = _payRate;
            sunday = _sunday;
            monday = _monday;
            tuesday = _tuesday;
            wednesday = _wednesday;
            thrusday = _thrusday;
            friday = _friday;
            saturday = _saturday;
        }
        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;
            String connString = builder.ToString();
            builder = null;
            Console.WriteLine(connString);
            dbConn = new MySqlConnection(connString);
        }
        public static UserTimesheet getTimesheet()
        {
            //List<TimesheetDatabaseSearch> timesheet = new List<TimesheetDatabaseSearch>();
            String query = "SELECT * FROM omnia.timesheet where employee LIKE " + LoginDatabaseSearch.selectedUser.ID + ";";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String payRate = reader["payRate"].ToString();
                String sunday = reader["sunday"].ToString();
                String monday = reader["monday"].ToString();
                String tuesday = reader["tuesday"].ToString();
                String wednesday = reader["wednesday"].ToString();
                String thrusday = reader["thrusday"].ToString();
                String friday = reader["friday"].ToString();    
                String saturday = reader["saturday"].ToString();

                //TimesheetDatabaseSearch u = new TimesheetDatabaseSearch(payRate, sunday, monday, tuesday, wednesday, thrusday, friday, saturday);
                userTimesheet = new UserTimesheet(payRate, sunday, monday, tuesday, wednesday, thrusday, friday, saturday);

                //timesheet.Add(u);
            }
            dbConn.Close();
            return userTimesheet;
        }

        public void UpdateTimesheet(String _sunday, String _monday, String _tuesday, String _wednesday, String _thrusday, String _friday, String _saturday)
        {
            //List<TimesheetDatabaseSearch> timesheet = new List<TimesheetDatabaseSearch>();
            String query = "UPDATE omnia.timesheet SET sunday = " + _sunday + ", monday = " + _monday + ", tuesday = " + _tuesday + ", wednesday = " + _wednesday + ", thrusday = " + _thrusday +
                ", friday = " + _friday + ", saturday = " + _saturday + " WHERE employee = " + LoginDatabaseSearch.selectedUser.ID + ";";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            dbConn.Close();
        }
    }
}
