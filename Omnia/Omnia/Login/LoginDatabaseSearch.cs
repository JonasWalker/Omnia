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
        public String userUsername { get; private set; }
        public String userPassword { get; private set; }
        public String userRole { get; private set; }

        public static SelectedUser selectedUser;
        
        public struct SelectedUser
        {
            public String ID;
            public String firstName;
            public String lastName;
            public String username;
            public String password;
            public String role;
            
            public SelectedUser(String _ID, String _firstName = null, String _lastName = null, String _username = null, String _password = null, String _role = null)
            {
                ID = _ID;
                firstName = _firstName;
                lastName = _lastName;
                username = _username;
                password = _password;
                role = _role;
            }
        }

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
        public static int Login(String text = null, String text2 = null)
        {
            List<LoginDatabaseSearch> user = new List<LoginDatabaseSearch>();
            String query;

            query = "SELECT * FROM omnia.users where username = \"" + text + "\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            String idusers = "";
            String userFirstName = "";
            String userLastName = "";
            String userUsername = "";
            String userPassword = "";
            String userRole = "";

            while (reader.Read())
            {
                idusers = reader["idusers"].ToString();
                userFirstName = reader["userFirstName"].ToString();
                userLastName = reader["userLastName"].ToString();
                userUsername = reader["username"].ToString();
                userPassword = reader["password"].ToString();
                userRole = reader["userRole"].ToString();
                LoginDatabaseSearch u = new LoginDatabaseSearch(idusers, userFirstName, userLastName, userPassword, userRole);

                user.Add(u);
            }
            dbConn.Close();
            if(userUsername != text)
            {
                //incorrect username
                return 1;
            }
            if (userPassword != text2)
            {
                //incorrect password
                return 2;
            }
            if (userUsername == text && userPassword == text2)
            {
                selectedUser = new SelectedUser(idusers, userFirstName, userLastName, userUsername, userPassword, userRole);
                //username and password is correct
                return 0;
            }

            //4 = something went wrong
            return 4;
        }
    }
}
