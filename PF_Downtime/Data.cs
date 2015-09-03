using System.Collections.Generic;

namespace PF_Downtime
{
    /// <summary>
    /// Holds information from the database for easy access, as well as handling the single Organization record the program works with
    /// </summary>
    internal class Data
    {
        /// <summary>
        /// List of Resources from the database
        /// </summary>
        public static List<Models.BaseResource> ResourceList;
        /// <summary>
        /// List of Rooms from the database
        /// </summary>
        public static List<Models.BaseRoom> RoomList;
        /// <summary>
        /// List of Room Augmentations from the database
        /// </summary>
        public static List<Models.BaseRoom_Augmentation> Room_AugmentationList;
        /// <summary>
        /// List of Teams from the database
        /// </summary>
        public static List<Models.BaseTeam> TeamList;
        /// <summary>
        /// List of settlement limits from the database
        /// </summary>
        public static List<Models.BaseLimit> LimitList;
        /// <summary>
        /// List of managers from the database
        /// </summary>
        public static List<Models.BaseManager> ManagerList;
        /// <summary>
        /// Instance of the SQL Interface class to populate lists
        /// </summary>
        private SQL_Interface SQL = new SQL_Interface();

        /// <summary>
        /// Organization record the program revolves around
        /// </summary>
        public static Models.Organization Organization { get; set; } = new Models.Organization();

        /// <summary>
        /// Populates the lists on this class from the database
        /// </summary>
        public void LoadBaseData()
        {
            ResourceList = SQL.getResource();
            RoomList = SQL.getRoom();
            Room_AugmentationList = SQL.getRoom_Augmentation();
            TeamList = SQL.getTeam();
            LimitList = SQL.getLimit();
            ManagerList = SQL.getManager();
        }
    }
}