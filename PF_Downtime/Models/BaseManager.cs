using System;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents a Manager for downtime organizations
    /// </summary>
    public class BaseManager
    {
        /// <summary>
        /// Unique identifier from the database
        /// </summary>
        public Int64 ManagerID { get; set; } = 0;
        /// <summary>
        /// User specified name
        /// </summary>
        public String Name { get; set; } = "";
        /// <summary>
        /// GP cost per day
        /// </summary>
        public Int64 Cost { get; set; } = 0;
        /// <summary>
        /// Skills this manager is trained in
        /// </summary>
        public String Skills { get; set; } = "";
        /// <summary>
        /// User specified description of manager
        /// </summary>
        public String Description { get; set; } = "";

        /// <summary>
        /// Creates a blank Manager object
        /// </summary>
        public BaseManager() {}

        /// <summary>
        /// Creates a manager object
        /// </summary>
        /// <param name="ManagerID">Unique identifier from the database</param>
        /// <param name="Name">User specified name</param>
        /// <param name="Cost">GP cost per day</param>
        /// <param name="Skills">Managers trained skills</param>
        /// <param name="Description">User specified description of manager</param>
        public BaseManager(Int64 ManagerID, String Name, Int64 Cost, String Skills, String Description)
        {
            this.ManagerID = ManagerID;
            this.Name = Name;
            this.Cost = Cost;
            this.Skills = Skills;
            this.Description = Description;
        }

        /// <summary>
        /// User-viewable lite manager summary
        /// </summary>
        public String Display
        {
            get
            {
                return Name + " " + Cost + "gp/day";
            }
        }
    }
}
