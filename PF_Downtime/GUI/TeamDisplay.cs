using System;
using System.Collections.Generic;
using PF_Downtime.Models;

namespace PF_Downtime
{
    /// <summary>
    /// Allows users to edit the organizations objects
    /// </summary>
    public partial class TeamDisplay : ObjectDisplay
    {
        /// <summary>
        /// Temporary OrgTeam object to be added to the Teams list
        /// References TempObject
        /// </summary>
        public OrgTeam TempTeam { get
            {
                return (OrgTeam)TempObject;
            }
            set
            {
                TempObject = value;
            }
        }

        /// <summary>
        /// Instantiates
        /// </summary>
        /// <param name="Teams"></param>
        public TeamDisplay(List<OrgTeam> Teams) : base()
        {
            InitializeComponent();
            Objects.Clear();
            Objects.AddRange(Teams);
            Text = "Team Display";
            //DisableAugmentList();
        }

        /// <summary>
        /// Reinstantiates the TempTeam object
        /// </summary>
        public override void RespawnTempObject()
        {
            TempTeam = new OrgTeam();
        }

        /// <summary>
        /// Populates Size_Text with size info based on TempObject.Size
        /// </summary>
        public override String BuildSizeText()
        {
            return TempTeam.Size_Range;
        }

        /// <summary>
        /// Clears the Organization's OrgTeam list and repopulates it from this screen
        /// </summary>
        public override void UpdateObjectList()
        {
            Data.Organization.Teams.Clear();
            Data.Organization.Teams.AddRange(Objects.ConvertAll<OrgTeam>(x => (OrgTeam)x));
        }

        /// <summary>
        /// Returns a BaseObject type list of BaseTeams
        /// </summary>
        /// <returns></returns>
        public override List<BaseObject> BaseObjectList()
        {
            List<BaseObject> temp = new List<BaseObject>();
            temp.AddRange(Data.TeamList.ConvertAll<BaseObject>(x => (BaseObject)x));
            return temp;
        }

        /// <summary>
        /// Returns a Base_Augmentation type list of Team Augmentation
        /// Team Augmentations do not currently exists, so this returns a blank list
        /// </summary>
        /// <returns></returns>
        public override List<Base_Augmentation> BaseAugmentList()
        {
            List<Base_Augmentation> temp = new List<Base_Augmentation>();
            //temp.AddRange(BusinessLayer.Team_AugmentationList.ConvertAll<Base_Augmentation>(x => (Base_Augmentation)x));
            return temp;
        }
    }
}