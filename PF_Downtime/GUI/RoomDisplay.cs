using System;
using System.Collections.Generic;
using PF_Downtime.Models;

namespace PF_Downtime
{
    /// <summary>
    /// Allows users to edit the organizations objects
    /// </summary>
    public partial class RoomDisplay : ObjectDisplay
    {
        /// <summary>
        /// Temporary OrgRoom object to be added to the rooms list
        /// References TempObject
        /// </summary>
        public OrgRoom TempRoom { get
            {
                return (OrgRoom)TempObject;
            }
            set
            {
                TempObject = value;
            }
        }

        /// <summary>
        /// Instantiates
        /// </summary>
        /// <param name="Rooms"></param>
        public RoomDisplay(List<OrgRoom> Rooms) : base()
        {
            InitializeComponent();
            Objects.Clear();
            Objects.AddRange(Rooms);
            Text = "Room Display";
        }

        /// <summary>
        /// Reinstantiates the TempRoom object
        /// </summary>
        public override void RespawnTempObject()
        {
            TempRoom = new OrgRoom();
        }

        /// <summary>
        /// Populates Size_Text with size info based on TempObject.Size
        /// </summary>
        public override String BuildSizeText()
        {
            return TempRoom.Size_Range;
        }

        public override String MaxSizeText()
        {
            return TempRoom.Max_Size.ToString();
        }

        /// <summary>
        /// Clears the Organization's OrgRoom list and repopulates it from this screen
        /// </summary>
        public override void UpdateObjectList()
        {
            Data.Organization.Rooms.Clear();
            Data.Organization.Rooms.AddRange(Objects.ConvertAll<OrgRoom>(x => (OrgRoom)x));
        }

        /// <summary>
        /// Returns a BaseObject type list of BaseRooms
        /// </summary>
        /// <returns></returns>
        public override List<BaseObject> BaseObjectList()
        {
            List<BaseObject> temp = new List<BaseObject>();
            temp.AddRange(Data.RoomList.ConvertAll<BaseObject>(x => (BaseObject)x));
            return temp;
        }

        /// <summary>
        /// Returns a Base_Augmentation type list of Room Augmentation
        /// </summary>
        /// <returns></returns>
        public override List<Base_Augmentation> BaseAugmentList()
        {
            List<Base_Augmentation> temp = new List<Base_Augmentation>();
            temp.AddRange(Data.Room_AugmentationList.ConvertAll<Base_Augmentation>(x => (Base_Augmentation)x));
            return temp;
        }
    }
}