using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents settlement sizes and their spending limitations
    /// </summary>
    public class BaseBlackMarket
    {
        /// <summary>
        /// Unique Identifier from the database
        /// </summary>
        public Int64 Limit_ID { get; set; } = 0;
        /// <summary>
        /// Size classification of the settlement
        /// </summary>
        public String BlackMarket { get; set; } = "";
        /// <summary>
        /// Hard limit on how many resources can be spent per day.
        /// This is applied to all resources.  This is not per resource.
        /// </summary>
        public Int64 Limit { get; set; } = 0;

        /// <summary>
        /// Instantiates a base Limit object with 0 or blank values.
        /// </summary>
        public BaseBlackMarket() { }
        /// <summary>
        /// Instantiates a base limit object
        /// </summary>
        /// <param name="Limit_ID">Unique identifier from the database</param>
        /// <param name="Settlement">Settlement size classification</param>
        /// <param name="Limit">Resource spending limit per day</param>
        public BaseBlackMarket(Int64 Limit_ID, String BlackMarket, Int64 Limit)
        {
            this.Limit_ID = Limit_ID;
            this.BlackMarket = BlackMarket;
            this.Limit = Limit;
        }

        /// <summary>
        /// Generates a display string to show a simple view of this onject to the user.
        /// Should probably just replace ToString with this?
        /// </summary>
        public String Info
        {
            get
            {
                return BlackMarket.PadRight(15) + " - Spending Limit:" + Limit + "/day";
            }
        }
    }
}
