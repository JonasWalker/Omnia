﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Omnia
{
    public class PartsDatabaseSearch
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "omnia";
        private const String UID = "JonasWalker";
        private const String PASSWORD = "jonas1999";
        private static MySqlConnection dbConn;

        public String idparts { get; private set; }
        public String partNumber { get; private set; }
        public String partDescription { get; private set; }
        public String partQty { get; private set; }
        public String partMSRP { get; private set; }
        public String partCost { get; private set; }
        public String partNote { get; private set; }

        public Part part { get; private set; }

        public struct Part
        {
            public String partID;
            public String partNumber;
            public String partDescription;
            public String partQty;
            public String partMSRP;
            public String partCost;
            public String partNote;
            public Part(String _partID = null, String _partNumber = null, String _partDescription = null, String _partQty = null, 
                String _partMSRP = null, String _partCost = null, String _partNote = null)
            {
                partID = _partID;
                partNumber = _partNumber;
                partDescription = _partDescription;
                partQty = _partQty;
                partMSRP = _partMSRP;
                partCost = _partCost;
                partNote = _partNote;
            }
        }

        public PartsDatabaseSearch()
        {

        }

        public PartsDatabaseSearch(String _ID)
        {
            idparts = _ID;
            GetSearchedPartID(_ID);
        }

        private PartsDatabaseSearch(String id, String pNum, String pD, String pQ, String pM, String pC, String pN)
        {
            idparts = id;
            partNumber = pNum;
            partDescription = pD;
            partQty = pQ;
            partMSRP = pM;
            partCost = pC;
            partNote = pN;
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

        public static List<PartsDatabaseSearch> GetAllParts()
        {
            List<PartsDatabaseSearch> parts = new List<PartsDatabaseSearch>();
            String query = "SELECT * FROM omnia.parts;";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader =  cmd.ExecuteReader();

            while(reader.Read())
            {
                String idparts = reader["idparts"].ToString();
                String partNumber = reader["partNumber"].ToString();
                String partDescription = reader["partDescription"].ToString();
                String partQty = reader["partQty"].ToString();
                String partMSRP = reader["partMSRP"].ToString();
                String partCost = reader["partCost"].ToString();
                String partNote = reader["partNote"].ToString();

                PartsDatabaseSearch u = new PartsDatabaseSearch(idparts, partNumber, partDescription, partQty, partMSRP, partCost, partNote);

                parts.Add(u);

            }

            dbConn.Close();

            return parts;
        }

        public static List<PartsDatabaseSearch> GetSearchedParts(String text = null, String text2 = null)
        {
            List<PartsDatabaseSearch> parts = new List<PartsDatabaseSearch>();
            String query;
            if (text != null && text2 == null)
            {
                query = "SELECT * FROM omnia.parts where partNumber LIKE \"%" + text + "%\" ORDER BY partNumber ASC;";
            }
            else if(text == null && text2 != null)
            {
                query = "SELECT * FROM omnia.parts where partDescription LIKE \"%" + text2 + "%\"ORDER BY partDescription ASC;";
            }
            else
            {
                query = "SELECT * FROM omnia.parts where partNumber LIKE \"%" + text + 
                    "%\" AND partDescription LIKE \"%" + text2 + "%\" ORDER BY partNumber ASC;";
            }

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String idparts = reader["idparts"].ToString();
                String partNumber = reader["partNumber"].ToString();
                String partDescription = reader["partDescription"].ToString();
                String partQty = reader["partQty"].ToString();
                String partMSRP = reader["partMSRP"].ToString();
                String partCost = reader["partCost"].ToString();
                String partNote = reader["partNote"].ToString();

                PartsDatabaseSearch u = new PartsDatabaseSearch(idparts, partNumber, partDescription, partQty, partMSRP, partCost, partNote);

                parts.Add(u);

            }

            dbConn.Close();

            return parts;
        }

        public void GetSearchedPartID(String _ID)
        {
            String query = "SELECT * FROM omnia.parts WHERE idparts = " + _ID + ";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String idparts = reader["idparts"].ToString();
                String partNumber = reader["partNumber"].ToString();
                String partDescription = reader["partDescription"].ToString();
                String partQty = reader["partQty"].ToString();
                String partMSRP = reader["partMSRP"].ToString();
                String partCost = reader["partCost"].ToString();
                String partNote = reader["partNote"].ToString();

                part = new Part(idparts, partNumber, partDescription, partQty, partMSRP, partCost, partNote);
            }

            dbConn.Close();

        }

        public void EditPartInfo(String _idpartrs, String _partNumber, String _partDescription, String _partQty, 
            String _partMSRP, String _partCost, String _partNote)
        {
            String query = "UPDATE omnia.parts SET partNumber = \'" + _partNumber + "\', partDescription = \'" + _partDescription + "\', partQty = \'" + _partQty +
                "\', partMSRP = \'" + _partMSRP + "\', partCost = \'" + _partCost + "\', partNote = \'" + _partNote + "\'WHERE idparts = " + _idpartrs + ";";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            dbConn.Close();
        }

        public static PartsDatabaseSearch Insert(String u, String p)
        {
            return null;
        }

        public void Update(string u, string p)
        {

        }

        public void Delete()
        {

        }


    }
}
