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
        /// BaseResource object showing what this object adds to earnings checks
        /// </summary>
        public BaseResource ActiveResource { get; set; } = new BaseResource();

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
        /// <summary>
        /// Goods earnings modifier
        /// </summary>
        public Int64 Earn_Goods { get; set; } = 0;
        /// <summary>
        /// GP earnings modifier
        /// </summary>
        public Int64 Earn_GP { get; set; } = 0;
        /// <summary>
        /// Influence earnings modifier
        /// </summary>
        public Int64 Earn_Influence { get; set; } = 0;
        /// <summary>
        /// Labor earnings modifier
        /// </summary>
        public Int64 Earn_Labor { get; set; } = 0;
        /// <summary>
        /// Magic earnings modifier
        /// </summary>
        public Int64 Earn_Magic { get; set; } = 0;

    }
}
