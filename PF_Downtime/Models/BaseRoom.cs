using System;
using System.Linq;

namespace PF_Downtime.Models
{
    /// <summary>
    /// BaseRoom inherits from BaseObject and represents a room for an organization
    /// Public attributes to allow XML serialization
    /// </summary>
    public class BaseRoom : BaseObject
    {
        /// <summary>
        /// Instantiates a room with the listed values
        /// </summary>
        /// <param name="Room_ID">Unique identifier from database</param>
        /// <param name="Name">Type of room</param>
        /// <param name="Description">Description of room</param>
        /// <param name="Benefit">Special benefits</param>
        /// <param name="Earn_Goods">Goods earning modifier</param>
        /// <param name="Earn_Influence">Influence earning modifier</param>
        /// <param name="Earn_Labor">Labor earning modifier</param>
        /// <param name="Earn_Magic">Magic earning modifier</param>
        /// <param name="Earn_GP">GP earning modifier</param>
        /// <param name="Cost_Goods">Goods cost to construct room</param>
        /// <param name="Cost_Influence">Influence cost to construct room</param>
        /// <param name="Cost_Labor">Labor cost to construct room</param>
        /// <param name="Cost_Magic">Magic cost to construct room</param>
        /// <param name="Days">Time to complete construction after payment is complete</param>
        /// <param name="Size_Min">Minimum size of room (5 ft squares)</param>
        /// <param name="Size_Max">Maximum size of room (5 ft squares)</param>
        public BaseRoom(Int64 Room_ID, String Name, String Description, String Benefit, Int64 Earn_Goods, Int64 Earn_Influence, Int64 Earn_Labor, Int64 Earn_Magic, Int64 Earn_GP,
            Int64 Cost_Goods, Int64 Cost_Influence, Int64 Cost_Labor, Int64 Cost_Magic, Int64 Days, Int64 Size_Min, Int64 Size_Max)
        {
            this.Room_ID = Room_ID;
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
            this.Size_Min = Size_Min;
            this.Size_Max = Size_Max;
        }

        /// <summary>
        /// Instantiates a blank BaseRoom object
        /// </summary>
        public BaseRoom()
        {
        }

        /// <summary>
        /// Unique identifier from database
        /// Writes to the ID field
        /// </summary>
        public Int64 Room_ID { get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        /// <summary>
        /// Maximum size of room (5 ft squares)
        /// </summary>
        public Int64 Size_Max { get; set; } = 0;
        /// <summary>
        /// Minimum size of room (5 ft squares)
        /// </summary>
        public Int64 Size_Min { get; set; } = 0;
    }
}