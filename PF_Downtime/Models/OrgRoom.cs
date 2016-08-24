using System;
using System.Collections.Generic;
using System.Linq;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents an Organization Room object
    /// Inherits from OrgObject
    /// </summary>
    public class OrgRoom : OrgObject
    {
        /// <summary>
        /// Instantiates an OrgRoom object
        /// </summary>
        /// <param name="Name">User controlled Room Name</param>
        /// <param name="Room">Type of BaseRoom object to determine base stats</param>
        /// <param name="Augmentations">List of BaseRoom_Augmentations to apply to the base room</param>
        /// <param name="Notes">User controlled room notes</param>
        /// <param name="ActiveResource">Resource this room is currently generating</param>
        public OrgRoom(String Name, BaseRoom Room, List<BaseRoom_Augmentation> Augmentations, String Notes, BaseResource ActiveResource)
        {
            this.Name = Name;
            this.Room = Room;
            this.Augmentations.Clear();
            this.Augmentations.AddRange(Augmentations);
            this.Notes = Notes;
            this.ActiveResource = ActiveResource;
        }

        /// <summary>
        /// Instantiates a blank OrgRoom object
        /// </summary>
        public OrgRoom() { }

        /// <summary>
        /// List of Augmentation objects to apply to this room
        /// Uses the Augmentations list attribute
        /// </summary>
        public List<BaseRoom_Augmentation> Room_Augmentations { get
            {
                return  Augmentations.Cast<BaseRoom_Augmentation>().ToList();
            }
            set
            {
                Augmentations.Clear();
                Augmentations.AddRange(value);
            } }

        /// <summary>
        /// BaseRoom object to determine base stats
        /// Uses the Object attribute
        /// </summary>
        public BaseRoom Room { get
            {
                return (BaseRoom)Object;
            } set
            {
                Object = value;
            }
        }

        /// <summary>
        /// Builds a user readable string representing the size range of the room
        /// </summary>
        public String Size_Range
        {
            get
            {
                return (Room.Size_Min + Augmentations.Sum(e => ((BaseRoom_Augmentation)e).Size)) + " to " + (Room.Size_Max + Augmentations.Sum(e => ((BaseRoom_Augmentation)e).Size));
            }
        }

        /// <summary>
        /// Returns the lowest size limit imposed by all room augmentations.  Ignores 0s.
        /// </summary>
        public Int64 Max_Size
        {
            get
            {
                return (Augmentations.Where(e => ((BaseRoom_Augmentation)e).Max_Size != 0).Select(e => ((BaseRoom_Augmentation)e).Max_Size).DefaultIfEmpty().Min() );
            }

        }
    }
}