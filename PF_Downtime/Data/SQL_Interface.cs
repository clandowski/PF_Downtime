using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace PF_Downtime
{
    /// <summary>
    /// Contains methods to interact with the SQLite database
    /// </summary>
    internal class SQL_Interface
    {
        /// <summary>
        /// SQLite Connection object
        /// </summary>
        private SQLiteConnection sql_con;
        /// <summary>
        /// SQLite command object
        /// </summary>
        private SQLiteCommand sql_cmd;
        /// <summary>
        /// SQLite DataReader object
        /// </summary>
        private SQLiteDataReader DB;

        /// <summary>
        /// Reads limits from the baseLimits table in the database and constructs a list of them
        /// </summary>
        /// <returns>List of BaseLimits</returns>
        public List<Models.BaseLimit> getLimit()
        {
            List<Models.BaseLimit> Limits = new List<Models.BaseLimit>();

            SetConnection();
            OpenDB();

            DB = ExecuteReader("select * from baseLimits");
            while (DB.Read())
            {
                Limits.Add(new Models.BaseLimit((Int64)DB["Limit_ID"], (String)DB["Settlement"], (Int64)DB["Limit"]));
            }

            CloseDB();

            return Limits;
        }

        /// <summary>
        /// Reads managers from the baseManagers table in the database and constructs a list of them
        /// </summary>
        /// <returns>List of BaseManagers</returns>
        public List<Models.BaseManager> getManager()
        {
            List<Models.BaseManager> Managers = new List<Models.BaseManager>();

            SetConnection();
            OpenDB();

            DB = ExecuteReader("select * from baseManagers");
            while (DB.Read())
            {
                Managers.Add(new Models.BaseManager((Int64)DB["Manager_ID"], (String)DB["Name"], (Int64)DB["Cost"], (String)DB["Skills"], (String)DB["Description"]));
            }

            CloseDB();

            return Managers;
        }

        /// <summary>
        /// Reads resources from the baseResources table in the database and constructs a list of them
        /// </summary>
        /// <returns>List of BaseResources</returns>
        public List<Models.BaseResource> getResource()
        {
            List<Models.BaseResource> Resources = new List<Models.BaseResource>();

            SetConnection();
            OpenDB();

            DB = ExecuteReader("select * from baseResources");
            while (DB.Read())
            {
                Resources.Add(new Models.BaseResource((Int64)DB["Resource_ID"], (String)DB["Name"], (Int64)DB["Cost_Earn"]));
            }

            CloseDB();

            return Resources;
        }

        /// <summary>
        /// Reads rooms from the baseRooms table in the database and constructs a list of them
        /// </summary>
        /// <returns>List of BaseRooms</returns>
        public List<Models.BaseRoom> getRoom()
        {
            List<Models.BaseRoom> Rooms = new List<Models.BaseRoom>();

            SetConnection();
            OpenDB();

            DB = ExecuteReader("select * from baseRooms");
            while (DB.Read())
            {
                Rooms.Add(new Models.BaseRoom((Int64)DB["Room_ID"], (String)DB["Name"], (String)DB["Description"], (String)DB["Benefit"], (Int64)DB["Earn_Goods"], (Int64)DB["Earn_Influence"], (Int64)DB["Earn_Labor"], (Int64)DB["Earn_Magic"], (Int64)DB["Earn_GP"]
                    , (Int64)DB["Cost_Goods"], (Int64)DB["Cost_Influence"], (Int64)DB["Cost_Labor"], (Int64)DB["Cost_Magic"], (Int64)DB["Days"], (Int64)DB["Size_Min"], (Int64)DB["Size_Max"]));
            }

            CloseDB();

            return Rooms;
        }

        /// <summary>
        /// Reads room augmentations from the baseRoom_Augmentations table in the database and constructs a list of them
        /// </summary>
        /// <returns>List of BaseRoom_Augmentations</returns>
        public List<Models.BaseRoom_Augmentation> getRoom_Augmentation()
        {
            List<Models.BaseRoom_Augmentation> Room_Augmentations = new List<Models.BaseRoom_Augmentation>();

            SetConnection();
            OpenDB();

            DB = ExecuteReader("select * from baseRoom_Augmentations");
            while (DB.Read())
            {
                Room_Augmentations.Add(new Models.BaseRoom_Augmentation((Int64)DB["Augment_ID"], (String)DB["Name"], (String)DB["Benefit"], (Int64)DB["Earn_Goods"], (Int64)DB["Earn_Influence"], (Int64)DB["Earn_Labor"], (Int64)DB["Earn_Magic"], (Int64)DB["Earn_GP"]
                    , (Int64)DB["Cost_Goods"], (Int64)DB["Cost_Influence"], (Int64)DB["Cost_Labor"], (Int64)DB["Cost_Magic"], (Int64)DB["Days"], (Int64)DB["Size"]));
            }

            CloseDB();

            return Room_Augmentations;
        }

        /// <summary>
        /// Reads teams from the baseTeams table in the database and constructs a list of them
        /// </summary>
        /// <returns>List of BaseTeams</returns>
        public List<Models.BaseTeam> getTeam()
        {
            List<Models.BaseTeam> Teams = new List<Models.BaseTeam>();

            SetConnection();
            OpenDB();

            DB = ExecuteReader("select * from baseTeams");
            while (DB.Read())
            {
                Teams.Add(new Models.BaseTeam((Int64)DB["Team_ID"], (String)DB["Name"], (String)DB["Description"], (String)DB["Benefit"], (Int64)DB["Earn_Goods"], (Int64)DB["Earn_Influence"], (Int64)DB["Earn_Labor"], (Int64)DB["Earn_Magic"], (Int64)DB["Earn_GP"]
                    , (Int64)DB["Cost_Goods"], (Int64)DB["Cost_Influence"], (Int64)DB["Cost_Labor"], (Int64)DB["Cost_Magic"], (Int64)DB["Days"], (Int64)DB["Size"]));
            }

            CloseDB();

            return Teams;
        }

        /// <summary>
        /// Opens the connection to the database
        /// </summary>
        private void OpenDB()
        {
            sql_con.Open();
        }

        /// <summary>
        /// Closes the connection to the database
        /// </summary>
        private void CloseDB()
        {
            sql_con.Close();
        }

        /// <summary>
        /// Executes a select statement against the database and returns the SqLiteDataReader object
        /// </summary>
        /// <param name="txtQuery">Query to be executed</param>
        /// <returns></returns>
        private SQLiteDataReader ExecuteReader(string txtQuery)
        {
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            return sql_cmd.ExecuteReader();
        }

        /// <summary>
        /// Executes an SQL statement without results, such as an update or insert
        /// </summary>
        /// <param name="txtQuery">Query to be executed</param>
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        /// <summary>
        /// Sets the connection information to the database
        /// </summary>
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=Downtime.db;Version=3;New=False;Compress=True;");
        }
    }
}