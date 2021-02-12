using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Omnia
{
    class LoginDatabaseSearch
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "omnia";
        private const String UID = "JonasWalker";
        private const String PASSWORD = "jonas1999";
        private static MySqlConnection dbConn;

        public String idusers { get; private set; }
        public String userFirstName { get; private set; }
        public String userLastName { get; private set; }
        public String userPassword { get; private set; }
        public String userRole { get; private set; }

        private LoginDatabaseSearch(String id, String uF, String uL, String uP, String uR)
        {
            idusers = id;
            userFirstName = uF;
            userLastName = uL;
            userPassword = uP;
            userRole = uR;
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
        public static int Login(String text, String text2)
        {
            List<LoginDatabaseSearch> user = new List<LoginDatabaseSearch>();
            String query;


            if (text == null && text2 == null)
            {
                //both username and password are null
                return 1;   
            }
            else if(text != null && text2 == null)
            {
                //password is null
                return 2;   
            }
            else if(text == null && text2 != null)
            {
                //username is null
                return 3;
            }
            else if(text != null && text2 != null)
            {
                //all good. search for the username
                query = "SELECT * FROM omnia.users where username = \"%" + text + "%\";";
            }
            else
            {
                //something went wrong
                return 4;
            }

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            String idusers = "";
            String userFirstName = "";
            String userLastName = "";
            String userPassword = "";
            String userRole = "";

            while (reader.Read())
            {
                idusers = reader["idusers"].ToString();
                userFirstName = reader["userFirstName"].ToString();
                userLastName = reader["userLastName"].ToString();
                userPassword = reader["userPassword"].ToString();
                userRole = reader["userRole"].ToString();
                LoginDatabaseSearch u = new LoginDatabaseSearch(idusers, userFirstName, userLastName, userPassword, userRole);

                user.Add(u);
            }
            dbConn.Close();

            //LoginDatabaseSearch u = new LoginDatabaseSearch(idusers, userFirstName, userLastName, userPassword, userRole);

            //customers.Add(u);

            //if(u.userPassword == passsword)
            //{
            //    //username and password is correct
            //    return 0;
            //}

            if (userPassword == text2)
            {
                //username and password is correct
                return 0;
            }



            return 4;
        }
    }
}
