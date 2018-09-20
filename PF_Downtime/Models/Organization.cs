using System;
using System.Collections.Generic;
using System.Linq;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents an organization record
    /// Public attributes to allow xml serialization
    /// This object encompases the majority of the functionality of this program
    /// Rooms and Teams are seperate lists, but could probably be condensed into a BaseObject list and parsed later..?
    /// This seems a bit more code-heavy than it should be, may want to clean and consolidate.  Is there a good way to get the Earnings and Costs code condensed?
    /// Realistically, resources shouldn't be hard coded, but I did not want to deal with the complexity involved in decoupling them when there will never be more resources added to the base game.
    /// </summary>
    [Serializable()]
    public class Organization
    {
        /// <summary>
        /// Instantiates a blank Organization object
        /// </summary>
        public Organization()
        {
            //Rooms = new List<OrgRoom>();
            //Teams = new List<OrgTeam>();
            //Managers = new List<OrgManager>();
            //Settlement = new OrgSettlement();
        }

        /// <summary>
        /// User psecified name of organization
        /// </summary>
        public String Name { get; set; } = "";
        /// <summary>
        /// User specified organization notes
        /// </summary>
        public String Notes { get; set; } = "";
        /// <summary>
        /// List of OrgRoom objects that make up this organization
        /// </summary>
        public List<OrgRoom> Rooms { get; set; } = new List<OrgRoom>();
        /// <summary>
        /// List of OrgTeam objects that make up this organization
        /// </summary>
        public List<OrgTeam> Teams { get; set; } = new List<OrgTeam>();
        /// <summary>
        /// Manager for this organization
        /// </summary>
        public List<OrgManager> Managers { get; set; } = new List<OrgManager>();
        /// <summary>
        /// Settlement for this organization
        /// </summary>
        public OrgSettlement Settlement { get; set; } = new OrgSettlement();
        /// <summary>
        /// Indicates wether construction and training happen in sequence or in parallel
        /// The rules say in sequence, but this is sometimes waved as it is incredibly time intensive
        /// </summary>
        public Boolean Parallel { get; set; } = false;

        /// <summary>
        /// Gets the total GP earning modifier from all rooms and teams
        /// Rooms and teams must have this set as their active resource and have no days remaining
        /// </summary>
        public Int64 Earn_GP
        {
            get
            {
                return Managers.Where(e => e.ActiveResource.Resource_ID == 0).Sum(e => e.Earn_GP + e.Org_Earn_GP);
            }
        }

        /// <summary>
        /// Gets the total Goods earning modifier from all rooms and teams
        /// Rooms and teams must have this set as their active resource and have no days remaining
        /// </summary>
        public Int64 Earn_Goods
        {
            get
            {
                return Managers.Where(e => e.ActiveResource.Resource_ID == 0).Sum(e => e.Earn_Goods + e.Org_Earn_Goods);
            }
        }

        /// <summary>
        /// Gets the total Influence earning modifier from all rooms and teams
        /// Rooms and teams must have this set as their active resource and have no days remaining
        /// </summary>
        public Int64 Earn_Influence
        {
            get
            {
                return Managers.Where(e => e.ActiveResource.Resource_ID == 0).Sum(e => e.Earn_Influence + e.Org_Earn_Influence);
            }
        }

        /// <summary>
        /// Gets the total Labor earning modifier from all rooms and teams
        /// Rooms and teams must have this set as their active resource and have no days remaining
        /// </summary>
        public Int64 Earn_Labor
        {
            get
            {
                return Managers.Where(e => e.ActiveResource.Resource_ID == 0).Sum(e => e.Earn_Labor + e.Org_Earn_Labor);
            }
        }

        /// <summary>
        /// Gets the total Magic earning modifier from all rooms and teams
        /// Rooms and teams must have this set as their active resource and have no days remaining
        /// </summary>
        public Int64 Earn_Magic
        {
            get
            {
                return Managers.Where(e => e.ActiveResource.Resource_ID == 0).Sum(e => e.Earn_Magic + e.Org_Earn_Magic);
            }
        }

        /// <summary>
        /// Gets the max possible GP earning modifier for all rooms and teams
        /// Rooms and teams must have no days remaining
        /// </summary>
        public Int64 Earn_GP_Max
        {
            get
            {
                return Rooms   .Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_GP) +
                       Teams   .Sum  (e => e.Earn_GP) +
                       Managers.Sum  (e => e.Earn_GP);
            }
        }

        /// <summary>
        /// Gets the max possible Goods earning modifier for all rooms and teams
        /// Rooms and teams must have no days remaining
        /// </summary>
        public Int64 Earn_Goods_Max
        {
            get
            {
                return Rooms   .Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Goods) +
                       Teams   .Sum  (e => e.Earn_Goods) +
                       Managers.Sum  (e => e.Earn_Goods);
            }
        }

        /// <summary>
        /// Gets the max possible Influence earning modifier for all rooms and teams
        /// Rooms and teams must have no days remaining
        /// </summary>
        public Int64 Earn_Influence_Max
        {
            get
            {
                return Rooms   .Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Influence) +
                       Teams   .Sum  (e => e.Earn_Influence) +
                       Managers.Sum  (e => e.Earn_Influence);
            }
        }

        /// <summary>
        /// Gets the max possible Labor earning modifier for all rooms and teams
        /// Rooms and teams must have no days remaining
        /// </summary>
        public Int64 Earn_Labor_Max
        {
            get
            {
                return Rooms.Where (e => e.DaysRemaining == 0).Sum(e => e.Earn_Labor) +
                       Teams.Sum   (e => e.Earn_Labor) +
                       Managers.Sum(e => e.Earn_Labor);
            }
        }

        /// <summary>
        /// Gets the max possible Magic earning modifier for all rooms and teams
        /// Rooms and teams must have no days remaining
        /// </summary>
        public Int64 Earn_Magic_Max
        {
            get
            {
                return Rooms   .Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Magic) +
                       Teams   .Sum  (e => e.Earn_Magic) +
                       Managers.Sum  (e => e.Earn_Magic);
            }
        }

        /// <summary>
        /// Gets to total cost in GP to purchase all rooms and teams remaining
        /// Only checks teams that have paid set to false
        /// </summary>
        public Int64 Cost_GP
        {
            get
            {
                return Rooms.Sum(e => e.Cost_GP) +
                       Teams.Sum(e => e.Cost_GP);
            }
        }

        /// <summary>
        /// Gets to total cost in goods to begin training and construction on all rooms and teams
        /// Only checks teams that have paid set to false
        /// </summary>
        public Int64 Cost_Goods
        {
            get
            {
                return Rooms.Sum(e => e.Cost_Goods) +
                       Teams.Sum(e => e.Cost_Goods);
            }
        }

        /// <summary>
        /// Gets to total cost in Influence to begin training and construction on all rooms and teams
        /// Only checks teams that have paid set to false
        /// </summary>
        public Int64 Cost_Influence
        {
            get
            {
                return Rooms.Sum(e => e.Cost_Influence) +
                       Teams.Sum(e => e.Cost_Influence);
            }
        }

        /// <summary>
        /// Gets to total cost in Labor to begin training and construction on all rooms and teams
        /// Only checks teams that have paid set to false
        /// </summary>
        public Int64 Cost_Labor
        {
            get
            {
                return Rooms.Sum(e => e.Cost_Labor) +
                       Teams.Sum(e => e.Cost_Labor);
            }
        }

        /// <summary>
        /// Gets to total cost in Magic to begin training and construction on all rooms and teams
        /// Only checks teams that have paid set to false
        /// </summary>
        public Int64 Cost_Magic
        {
            get
            {
                return Rooms.Sum(e => e.Cost_Magic) +
                       Teams.Sum(e => e.Cost_Magic);
            }
        }

        /// <summary>
        /// Gets to total time, in days, to finish constructing rooms
        /// Checks the parallel flag to determine if build times are parallel or sequential
        /// </summary>
        public Int64 ConstructionDaysRemaining { get
            {
                if (Rooms.Count > 0)
                {
                    if (Parallel)
                    {
                        return Rooms.Where(e => e.Paid == true).Select(e => e.DaysRemaining).DefaultIfEmpty(0).Max();
                    }
                    else
                    {
                        return Rooms.Where(e => e.Paid == true).Select(e => e.DaysRemaining).DefaultIfEmpty(0).Sum();
                    }
                }
                else
                {
                    return 0;
                }
            } }

        /// <summary>
        /// Gets to total time, in days, to finish training teams
        /// Checks the parallel flag to determine if build times are parallel or sequential
        /// </summary>
        public Int64 RecruitmentDaysRemaining { get
            {
                if (Teams.Count > 0)
                {
                    if (Parallel)
                    {
                        return Teams.Where(e => e.Paid == true).Select(e => e.DaysRemaining).DefaultIfEmpty(0).Max();
                    }
                    else
                    {
                        return Teams.Where(e => e.Paid == true).Select(e => e.DaysRemaining).DefaultIfEmpty(0).Sum();
                    }
                }
                else
                {
                    return 0;
                }
            } }

        /// <summary>
        /// Advances contruction and training of rooms and teams by the Days parameter
        /// If the parallel flag is true, all rooms and teams have their DaysToComplete value increased by Days, up to their total days
        /// If sequential, days are applied starting at the first room on the list with daystocomplete > 0 and applies them one at a time
        /// Days are applied first to rooms, then to teams
        /// </summary>
        /// <param name="Days"></param>
        public void AdvanceDays (Int32 Days)
        {
            if (Parallel)
            {
                foreach (Models.OrgRoom room in Data.Organization.Rooms)
                {
                    if (room.Paid)
                    {
                        room.DaysComplete = room.DaysComplete + (Days);
                    }
                }
                foreach (Models.OrgTeam team in Data.Organization.Teams)
                {
                    if (team.Paid)
                    {
                        team.DaysComplete = team.DaysComplete + (Days);
                    }
                }
            }
            else //If sequential
            {
                if (Days > 0)//Rooms
                {
                    foreach (Models.OrgRoom room in Data.Organization.Rooms)
                    {
                        if (room.Paid)
                        {
                            for (int i = (int)room.DaysRemaining; i > 0; i--)
                            {
                                if (Days > 0)
                                {
                                    room.DaysComplete = room.DaysComplete + 1;
                                    Days--;
                                }

                            }
                        }
                    }
                }

                if (Days > 0)//Teams
                {
                    foreach (Models.OrgTeam team in Data.Organization.Teams)
                    {
                        if (team.Paid)
                        {
                            for (int i = (int)team.DaysRemaining; i > 0; i--)
                            {
                                if (Days > 0)
                                {
                                    team.DaysComplete = team.DaysComplete + 1;
                                    Days--;
                                }

                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sets all rooms and teams Paid attribute to true
        /// </summary>
        public void PayAll()
        {
            Rooms.ForEach(e => e.Paid = true);
            Teams.ForEach(e => e.Paid = true);
        }

        /// <summary>
        /// Sets all rooms and teams Paid attribute to true
        /// </summary>
        public void UnPayAll()
        {
            Rooms.ForEach(e => e.Paid = false);
            Teams.ForEach(e => e.Paid = false);
        }
    }
}