using System;
using System.Linq;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents an organization component.  This should be inherited for object-specific classes.
    /// Variables are public to support XML serialization
    /// </summary>
    public class BaseObject
    {
        /// <summary>
        /// Unique identifier from database
        /// </summary>
        public Int64 ID { get; set; } = 0;
        /// <summary>
        /// Base name of object type
        /// </summary>
        public String Name { get; set; } = "";
        /// <summary>
        /// Description of the object
        /// </summary>
        public String Description { get; set; } = "";
        /// <summary>
        /// Special advantages this object grants
        /// </summary>
        public String Benefit { get; set; } = "";
        /// <summary>
        /// Days taken for object to become usable.  Begins after object is fully paid for.
        /// </summary>
        public Int64 Days { get; set; } = 0;

        /// <summary>
        /// Goods needed to create or train object
        /// </summary>
        public Int64 Cost_Goods { get; set; } = 0;
        /// <summary>
        /// Influence needed to create or train object
        /// </summary>
        public Int64 Cost_Influence { get; set; } = 0;
        /// <summary>
        /// Labor needed to create or train object
        /// </summary>
        public Int64 Cost_Labor { get; set; } = 0;
        /// <summary>
        /// Magic needed to create or train object
        /// </summary>
        public Int64 Cost_Magic { get; set; } = 0;
        
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

        /// <summary>
        /// GP cost to purchase object.
        /// This is calculated by the other Goods, Influence, Labor, and Magic costs using the resources purchase rates.
        /// </summary>
        public Int64 Cost_GP
        {
            get
            {
                return
                    Cost_Goods * Data.ResourceList.First(e => e.Name == "Goods").Cost_Purchase
                    + Cost_Influence * Data.ResourceList.First(e => e.Name == "Influence").Cost_Purchase
                    + Cost_Labor * Data.ResourceList.First(e => e.Name == "Labor").Cost_Purchase
                    + Cost_Magic * Data.ResourceList.First(e => e.Name == "Magic").Cost_Purchase;
            }
        }

        /// <summary>
        /// Generates a string for easy display of the Cost and Earning potential of the Object.
        /// </summary>
        public String Info
        {
            get
            {
                String Benefits = "";
                if (Benefit != null && !Benefit.Equals(""))
                {
                    Benefits = " !";
                }
                return Name.PadRight(20) + " " + Earn_Goods.ToString().PadRight(2) + "/" + Earn_Influence.ToString().PadRight(2) + "/" + Earn_Labor.ToString().PadRight(2) + "/" +
                    Earn_Magic.ToString().PadRight(2) + "/" + Earn_GP.ToString().PadRight(2) + " " + Cost_Goods.ToString().PadRight(3) + "/" + Cost_Influence.ToString().PadRight(3) +
                    "/" + Cost_Labor.ToString().PadRight(3) + "/" + Cost_Magic.ToString().PadRight(3) + "/" + Cost_GP.ToString().PadRight(6) + " " + Benefits;
            }
        }
    }
}
