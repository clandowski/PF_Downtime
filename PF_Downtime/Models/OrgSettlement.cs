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
            Settlement = new BaseSettlement();
            BlackMarket = new BaseBlackMarket();
        }

        /// <summary>
        /// BaseSettlement to base settlement spending limitations and size classification on
        /// </summary>
        public BaseSettlement Settlement;
        /// <summary>
        /// BaseBlackMarket to base Black Market spending limitations and size classification on
        /// </summary>
        public BaseBlackMarket BlackMarket;
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
