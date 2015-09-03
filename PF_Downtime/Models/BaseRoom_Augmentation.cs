using System;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Room specific augmentation.  Inherits from the Base_Augmentation object
    /// </summary>
    public class BaseRoom_Augmentation : Base_Augmentation
    {
        /// <summary>
        /// Room Augmentation object
        /// </summary>
        /// <param name="Augment_ID">Unique identifier from database</param>
        /// <param name="Name">Augmentation type</param>
        /// <param name="Benefit">Augmentation unique benefits</param>
        /// <param name="Earn_Goods">Augmentations Goods earning modifier for the base room</param>
        /// <param name="Earn_Influence">Augmentations Influence earning modifier for the base room</param>
        /// <param name="Earn_Labor">Augmentations Labor earning modifier for the base room</param>
        /// <param name="Earn_Magic">Augmentations Magic earning modifier for the base room</param>
        /// <param name="Earn_GP">Augmentations GP earning modifier for the base room</param>
        /// <param name="Cost_Goods">Goods cost to add Augmentation to room</param>
        /// <param name="Cost_Influence">Influence cost to add Augmentation to room</param>
        /// <param name="Cost_Labor">Labor cost to add Augmentation to room</param>
        /// <param name="Cost_Magic">Magic cost to add Augmentation to room</param>
        /// <param name="Days">Days to finish adding Augmentation to a room</param>
        /// <param name="Size">Additional space needed for room to support Augmentation</param>
        public BaseRoom_Augmentation(Int64 Augment_ID, String Name, String Benefit, Int64 Earn_Goods, Int64 Earn_Influence, Int64 Earn_Labor, Int64 Earn_Magic, Int64 Earn_GP,
            Int64 Cost_Goods, Int64 Cost_Influence, Int64 Cost_Labor, Int64 Cost_Magic, Int64 Days, Int64 Size)
        {
            this.Augment_ID = Augment_ID;
            this.Name = Name;
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
        /// Instantiates a blank BaseRoom_Augmentation
        /// </summary>
        public BaseRoom_Augmentation() {}

        /// <summary>
        /// Additional space needed for room to support Augmentation
        /// </summary>
        public Int64 Size { get; set; } = 0;

    }
}