using System;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents Organization Settlement information
    /// Shows spending limits and notes on the area
    /// </summary>
    public class OrgSettlement
    {
        /// <summary>
        /// Instantiates a blank OrgSettlement Object
        /// </summary>
        public OrgSettlement()
        {
            Limit = new BaseLimit();
        }

        /// <summary>
        /// BaseLimit to base settlement spending limitations and size classification on
        /// </summary>
        public BaseLimit Limit;
        /// <summary>
        /// User controlled field to describe organization location
        /// </summary>
        public String Location;
        /// <summary>
        /// User controlled field to hold notes on the organization
        /// </summary>
        public String Notes;
    }
}
