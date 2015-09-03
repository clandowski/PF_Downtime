using System;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents an Organization Team object
    /// Inherits from OrgObject
    /// </summary>
    public class OrgTeam : OrgObject
    {
        /// <summary>
        /// Instantiates an OrgTeam object
        /// </summary>
        /// <param name="Name">User controlled name of Team</param>
        /// <param name="Team">BaseTeam object to determine statistics</param>
        /// <param name="Notes">User controlled notes</param>
        /// <param name="ActiveResource">Resource this room is currently generating</param>
        /// <param name="DaysComplete"></param>
        public OrgTeam(String Name, BaseTeam Team, String Notes, Models.BaseResource ActiveResource)
        {
            this.Name = Name;
            this.Team = Team;
            this.ActiveResource = ActiveResource;
            this.Notes = Notes;
        }

        /// <summary>
        /// Instantiates a blank OrgTeam object
        /// </summary>
        public OrgTeam() { }

        /// <summary>
        /// BaseTeam object to determine base stats
        /// Uses the Object attribute
        /// </summary>
        public BaseTeam Team
        {
            get
            {
                return (BaseTeam)Object;
            }
            set
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
                return (Team.Size.ToString());
            }
        }
    }
}