using System;
using System.Linq;

namespace PF_Downtime.Models
{
    /// <summary>
    /// BaseTeam inherits from BaseObject and represents a Team for an organization
    /// Public attributes to allow XML serialization
    /// </summary>
    public class BaseTeam : BaseObject
    {
        /// <summary>
        /// Instantiates a room with the listed values
        /// </summary>
        /// <param name="Team_ID">Unique identifier from database</param>
        /// <param name="Name">Type of team</param>
        /// <param name="Description">Description of team</param>
        /// <param name="Benefit">Special benefits</param>
        /// <param name="Earn_Goods">Goods earning modifier</param>
        /// <param name="Earn_Influence">Influence earning modifier</param>
        /// <param name="Earn_Labor">Labor earning modifier</param>
        /// <param name="Earn_Magic">Magic earning modifier</param>
        /// <param name="Earn_GP">GP earning modifier</param>
        /// <param name="Cost_Goods">Goods cost to train team</param>
        /// <param name="Cost_Influence">Influence cost to train team</param>
        /// <param name="Cost_Labor">Labor cost to train team</param>
        /// <param name="Cost_Magic">Magic cost to train team</param>
        /// <param name="Days">Time to complete training after payment is complete</param>
        /// <param name="Size">Size of team (individuals)</param>
        public BaseTeam(Int64 Team_ID, String Name, String Description, String Benefit, Int64 Earn_Goods, Int64 Earn_Influence, Int64 Earn_Labor, Int64 Earn_Magic, Int64 Earn_GP,
            Int64 Cost_Goods, Int64 Cost_Influence, Int64 Cost_Labor, Int64 Cost_Magic, Int64 Days, Int64 Size)
        {
            this.ID = Team_ID;
            this.Name = Name;
            this.Description = Description;
            this.Benefit = Benefit;
            this.Earn_Goods = Earn_Goods;
            this.Earn_Influence = Earn_Influence;
            this.Earn_Labor = Earn_Labor;
            this.Earn_Magic = Earn_Magic;
            this.Earn_GP = Earn_GP;
            this.Cost_Goods = Cost_Goods;
            this.Cost_Influence = Cost_Influence;
            this.Cost_Labor = Cost_Labor;
            this.Cost_Magic = Cost_Magic;
            this.Days = Days;
            this.Size = Size;
        }

        /// <summary>
        /// Instantiates a blank BaseTeam object
        /// </summary>
        public BaseTeam() { }

        /// <summary>
        /// Size of team (Individuals)
        /// </summary>
        public Int64 Size { get; set; } = 0;

        /// <summary>
        /// Unique identifier from the database.  Writes to the ID field.
        /// </summary>
        public Int64 Team_ID { get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
    }
}