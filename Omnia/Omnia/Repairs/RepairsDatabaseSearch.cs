﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Omnia
{
    class RepairsDatabaseSearch
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "omnia";
        private const String UID = "JonasWalker";
        private const String PASSWORD = "jonas1999";
        private static MySqlConnection dbConn;

        public String repairID { get; private set; }
        public String repairTag { get; private set; }
        public String repairCustName { get; private set; }
        public String repairCustPhoneNumber { get; private set; }
        public String repairDescription { get; private set; }
        public String repairModel { get; private set; }
        public String repairSerial { get; private set; }
        public String repairNotes { get; private set; }
        public Repair repair { get; private set; }

        public struct Repair
        {
            public String repairID;
            public String repairTag;
            public String repairCustName;
            public String repairCustPhoneNumber;
            public String repairDescription;
            public String repairModel;
            public String repairSerial;
            public String repairNotes;

            public Repair(String _repairID = null, String _repairTag = null, String _repairCustName = null, String _repairCustPhoneNumber = null, String _repairDescription = null,
                String _repairModel = null, String _repairSerial = null, String _repairNotes = null)
            {
                repairID = _repairID;
                repairTag = _repairTag;
                repairCustName = _repairCustName;
                repairCustPhoneNumber = _repairCustPhoneNumber;
                repairDescription = _repairDescription;
                repairModel = _repairModel;
                repairSerial = _repairSerial;
                repairNotes = _repairNotes;
            }
        }

        public RepairsDatabaseSearch(String _repairID)
        {
            repairID = _repairID;
            SearchForRepairID();
        }

        private RepairsDatabaseSearch(String id, String rT, String rC, String rCNum, String rD, String rM, String rS, String rN)
        {
            repairID = id;
            repairTag = rT;
            repairCustName = rC;
            repairCustPhoneNumber = rCNum;
            repairDescription = rD;
            repairModel = rM;
            repairSerial = rS;
            repairNotes = rN;
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

        public static List<RepairsDatabaseSearch> GetAllRepairs()
        {
            List<RepairsDatabaseSearch> repairs = new List<RepairsDatabaseSearch>();

            String query = "SELECT * FROM omnia.repairs;";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String repairID = reader["repairID"].ToString();
                String repairTag = reader["repairTag"].ToString();
                String repairCustName = reader["repairCustName"].ToString();
                String repairCustPhoneNumber = reader["repairCustPhoneNumber"].ToString();
                String repairDescription = reader["repairDescription"].ToString();
                String repairModel = reader["repairModel"].ToString();
                String repairSerial = reader["repairSerial"].ToString();
                String repairNotes = reader["repairNotes"].ToString();

                RepairsDatabaseSearch u = new RepairsDatabaseSearch(repairID, repairTag, repairCustName, repairCustPhoneNumber, repairDescription, repairModel, repairSerial, repairNotes);

                repairs.Add(u);
            }

            dbConn.Close();

            return repairs;
        }

        public static List<RepairsDatabaseSearch> GetSearchedRepairs(String text, String text2, String text3)
        {
            List<RepairsDatabaseSearch> repairs = new List<RepairsDatabaseSearch>();
            String query;

            if(text != null && text2 == null && text3 == null)
            {
                query = "SELECT * FROM omnia.repairs where repairCustName LIKE \"%" + text + "%\" ORDER BY repairCustName ASC;";
            }
            else if(text == null && text2 != null && text3 == null)
            {
                query = "SELECT * FROM omnia.repairs where repairCustPhoneNumber LIKE \"%" + text2 + "%\"ORDER BY repairCustPhoneNumber ASC;";
            }
            else if(text == null && text2 == null && text3 != null)
            {
                query = "SELECT * FROM omnia.repairs where repairTag LIKE \"%" + text3 + "%\"ORDER BY repairTag ASC;";
            }
            else if(text != null && text2 != null && text3 == null)
            {
                query = "SELECT * FROM omnia.repairs where repairCustName LIKE \"%" + text +
                    "%\" AND repairCustPhoneNumber LIKE \"%" + text2 + "%\" ORDER BY repairCustName ASC;";
            }
            else if (text == null && text2 != null && text3 != null)
            {
                query = "SELECT * FROM omnia.repairs where repairCustPhoneNumber LIKE \"%" + text2 +
                    "%\" AND repairTag LIKE \"%" + text3 + "%\" ORDER BY repairCustPhoneNumber ASC;";
            }
            else if(text != null && text2 == null && text3 != null)
            {
                query = "SELECT * FROM omnia.repairs where repairCustName LIKE \"%" + text +
                    "%\" AND repairTag LIKE \"%" + text3 + "%\" ORDER BY repairCustName ASC;";
            }
            else
            {
                query = "SELECT * FROM omnia.repairs where repairCustName LIKE \"%" + text +
                    "%\" AND repairCustPhoneNumber LIKE \"%" + text2 + "%\" AND repairTag LIKE \"%" + text3 + "%\" ORDER BY repairCustName ASC;";
            }

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String repairID = reader["repairID"].ToString();
                String repairTag = reader["repairTag"].ToString();
                String repairCustName = reader["repairCustName"].ToString();
                String repairCustPhoneNumber = reader["repairCustPhoneNumber"].ToString();
                String repairDescription = reader["repairDescription"].ToString();
                String repairModel = reader["repairModel"].ToString();
                String repairSerial = reader["repairSerial"].ToString();
                String repairNotes = reader["repairNotes"].ToString();

                RepairsDatabaseSearch u = new RepairsDatabaseSearch(repairID, repairTag, repairCustName, repairCustPhoneNumber, repairDescription, repairModel, repairSerial, repairNotes);

                repairs.Add(u);
            }

            dbConn.Close();


            return repairs;
        }
        public void SearchForRepairID()
        {
            String query = "SELECT * FROM omnia.repairs WHERE repairID = \"" + repairID + "\";";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String repairID = reader["repairID"].ToString();
                String repairTag = reader["repairTag"].ToString();
                String repairCustName = reader["repairCustName"].ToString();
                String repairCustPhoneNumber = reader["repairCustPhoneNumber"].ToString();
                String repairDescription = reader["repairDescription"].ToString();
                String repairModel = reader["repairModel"].ToString();
                String repairSerial = reader["repairSerial"].ToString();
                String repairNotes = reader["repairNotes"].ToString();

                repair = new Repair(repairID, repairTag, repairCustName, repairCustPhoneNumber, repairDescription, repairModel, repairSerial, repairNotes);
            }
            dbConn.Close();
        }

        public void EditRepairInfo(String _repairID, String _repairTag, String _repairCustName, String _repairCustPhoneNumber, String _repairDescription,
                String _repairModel, String _repairSerial, String _repairNotes)
        {
            String query = "UPDATE omnia.repairs SET repairTag = \'" + _repairTag + "\', repairCustName = \'" + _repairCustName + "\', repairCustPhoneNumber = \'" + _repairCustPhoneNumber + "\', repairDescription = \'" + _repairDescription +
                "\', repairModel = \'" + _repairModel + "\', repairSerial = \'" + _repairSerial + "\', repairNotes = \'" + _repairNotes + "\'WHERE repairID = " + _repairID + ";";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            dbConn.Close();
        }
    }
}