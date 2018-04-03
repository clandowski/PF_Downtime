using System;
using System.Collections.Generic;
using System.Linq;

namespace PF_Downtime.Models
{
    /// <summary>
    /// OrgObject represents an objects that is part of an organization
    /// It contains a baseObject to get stats from, while holding notes and information decided by the user
    /// This is the base class for OrgRoom and OrgTeam
    /// </summary>
    public class OrgObject 
    {
        /// <summary>
        /// User controlled object name
        /// </summary>
        public String Name { get; set; } = "";
        /// <summary>
        /// User controlled object notes
        /// </summary>
        public String Notes { get; set; } = "";
        /// <summary>
        /// Indicates if the object has been paid for.  Used in earnings calculations
        /// </summary>
        public Boolean Paid { get; set; } = false;

        /// <summary>
        /// BaseResource object showing what this object adds to earnings checks
        /// </summary>
        public BaseResource ActiveResource { get; set; } = new BaseResource();
        /// <summary>
        /// List of Base_Augmentations that modify the Object
        /// </summary>
        public List<Base_Augmentation> Augmentations { get; set; } = new List<Base_Augmentation>();
        /// <summary>
        /// Base Object this derives stats such as earnings and cost from, such as a BaseRoom or BaseTeam.
        /// </summary>
        public BaseObject Object = new BaseObject();
        /// <summary>
        /// How many instances of the base object this consists of.
        /// </summary>
        public int Quantity = 1;

        /// <summary>
        /// Gets the cost in goods of the this object from its BaseObject and Base_Augmentations
        /// </summary>
        public Int64 Cost_Goods
        {
            get
            {
                return !Paid ? Quantity * (Object.Cost_Goods + Augmentations.Sum(e => e.Cost_Goods)) : 0;
            }
        }

        /// <summary>
        /// Gets the cost in gp of the this object from its BaseObject and Base_Augmentations
        /// </summary>
        public Int64 Cost_GP
        {
            get
            {
                return !Paid ? Quantity * (Object.Cost_GP + Augmentations.Sum(e => e.Cost_GP)) : 0;
            }
        }

        /// <summary>
        /// Gets the cost in influence of the this object from its BaseObject and Base_Augmentations
        /// </summary>
        public Int64 Cost_Influence
        {
            get
            {
                return !Paid ? Quantity * (Object.Cost_Influence + Augmentations.Sum(e => e.Cost_Influence)) : 0;
            }
        }

        /// <summary>
        /// Gets the cost in labor of the this object from its BaseObject and Base_Augmentations
        /// </summary>
        public Int64 Cost_Labor
        {
            get
            {
                return !Paid ? Quantity * (Object.Cost_Labor + Augmentations.Sum(e => e.Cost_Labor)) : 0;
            }
        }

        /// <summary>
        /// Gets the cost in magic of the this object from its BaseObject and Base_Augmentations
        /// </summary>
        public Int64 Cost_Magic
        {
            get
            {
                return !Paid ? Quantity * (Object.Cost_Magic + Augmentations.Sum(e => e.Cost_Magic)) : 0;
            }
        }

        /// <summary>
        /// Gets the total days for this object to become usable.  
        /// This is a sum of the BaseObject and all Augmentations
        /// </summary>
        public Int64 TotalDays
        {
            get
            {
                ///////////Data.Organization.Parallel
                if (Object == null)
                {
                    return 0;
                }
                else if (Augmentations == null)
                {
                    return (Data.Organization.Parallel ? 1 : Quantity) * Object.Days;
                }
                else
                {
                    return (Data.Organization.Parallel ? 1 : Quantity) * (Object.Days + Augmentations.Sum(e => e.Days));
                }
            }
        }

        /// <summary>
        /// Gets the total goods earning modifier.
        /// This is a sum of the BaseObject and all Augmentations
        /// </summary>
        public Int64 Earn_Goods
        {
            get
            {
                return Paid ? Quantity * (Object.Earn_Goods + Augmentations.Sum(e => e.Earn_Goods)) : 0;

            }
        }

        /// <summary>
        /// Gets the total gp earning modifier.
        /// This is a sum of the BaseObject and all Augmentations
        /// </summary>
        public Int64 Earn_GP
        {
            get
            {
                return Paid ? Quantity * (Object.Earn_GP + Augmentations.Sum(e => e.Earn_GP)) : 0;
            }
        }

        /// <summary>
        /// Gets the total influence earning modifier.
        /// This is a sum of the BaseObject and all Augmentations
        /// </summary>
        public Int64 Earn_Influence
        {
            get
            {
                return Paid ? Quantity * (Object.Earn_Influence + Augmentations.Sum(e => e.Earn_Influence)) : 0;
            }
        }

        /// <summary>
        /// Gets the total labor earning modifier.
        /// This is a sum of the BaseObject and all Augmentations
        /// </summary>
        public Int64 Earn_Labor
        {
            get
            {
                return Paid ? Quantity * (Object.Earn_Labor + Augmentations.Sum(e => e.Earn_Labor)) : 0;
            }
        }

        /// <summary>
        /// Gets the total magic earning modifier.
        /// This is a sum of the BaseObject and all Augmentations
        /// </summary>
        public Int64 Earn_Magic
        {
            get
            {
                return Paid ? Quantity * (Object.Earn_Magic + Augmentations.Sum(e => e.Earn_Magic)) : 0;
            }
        }

        /// <summary>
        /// Builds a preformated string to easily display object costs
        /// </summary>
        /// <returns>String showing total costs of each resource</returns>
        public String BuildCosts()
        {
            return "Goods " + Cost_Goods.ToString().PadRight(2) + " | Influence " + Cost_Influence.ToString().PadRight(2) +
                    " | Labor " + Cost_Labor.ToString().PadRight(2) + " | Magic " + Cost_Magic.ToString().PadRight(2) + " | Gold " + Cost_GP.ToString().PadRight(2);
        }
        /// <summary>
        /// Builds a preformated string to easily display earning modifiers
        /// </summary>
        /// <returns>String showing total earning mod of each resource</returns>
        public String BuildIncome()
        {
            return "Goods " + Earn_Goods.ToString().PadRight(2) + " | Influence " + Earn_Influence.ToString().PadRight(2) +
                    " | Labor " + Earn_Labor.ToString().PadRight(2) + " | Magic " + Earn_Magic.ToString().PadRight(2) + " | Gold " + Earn_GP.ToString().PadRight(2);
        }

        /// <summary>
        /// Gets the days remaining for this object to begin generating income
        /// This is the difference between the DaysComplete and the TotalDays
        /// </summary>
        public Int64 DaysRemaining
        {
            get
            {
                return TotalDays - DaysComplete;
            }
        }

        /// <summary>
        /// Private backend variable for DaysComplete
        /// </summary>
        private Int64 _DaysComplete;
        /// <summary>
        /// Days of training or construction that have went into this object
        /// Cannot exceed TotalDays
        /// </summary>
        public Int64 DaysComplete
        {
            get
            {
                return _DaysComplete;
            }
            set
            {
                if (value > TotalDays)//Limits value to not exceed TotalDays
                {
                    _DaysComplete = TotalDays;
                }
                else
                {
                    _DaysComplete = value;
                }
            }
        }

    }
}
