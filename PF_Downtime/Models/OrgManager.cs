using System;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents an organizations manager
    /// This consists of a BaseManager to show manager type, along with a user controlled name and notes
    /// </summary>
    public class OrgManager
    {
        /// <summary>
        /// Instantiates a blank OrgManager object
        /// </summary>
        public OrgManager() {
            Type = new BaseManager();
        }

        /// <summary>
        /// User controlled Manager Name
        /// </summary>
        public String Name { get; set; } = "";
        /// <summary>
        /// Type of BaseManager.  Determines stats of the manager such as cost and skills.
        /// </summary>
        public BaseManager Type { get; set; } = new BaseManager();
        /// <summary>
        /// User controlled Manager Notes
        /// </summary>
        public String Notes { get; set; } = "";

    }
}
