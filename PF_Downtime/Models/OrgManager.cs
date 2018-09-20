using System;
using System.Collections.Generic;
using System.Linq;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents an organizations manager
    /// This consists of a BaseManager to show manager type, along with a user controlled name and notes
    /// </summary>
    public class OrgManager
    {
        /// <summary>
        /// Instantiates a blank OrgManager object
        /// </summary>
        public OrgManager() {
            Type = new BaseManager();
        }

        /// <summary>
        /// Guid identifier
        /// </summary>
        public Guid ID { get; set; } = Guid.NewGuid();

        /// <summary>
        /// BaseResource object showing what this object adds to earnings checks
        /// </summary>
        public BaseResource ActiveResource { get; set; } = new BaseResource();

        /// <summary>
        /// User controlled Manager Name
        /// </summary>
        public String Name { get; set; } = "None";
        /// <summary>
        /// Type of BaseManager.  Determines stats of the manager such as cost and skills.
        /// </summary>
        public BaseManager Type { get; set; } = new BaseManager();
        /// <summary>
        /// User controlled Manager Notes
        /// </summary>
        public String Notes { get; set; } = "";
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

        public IEnumerable<Models.OrgRoom> RoomList { get { return Data.Organization.Rooms.Where(x => x.ManagerID == this.ID); } }

        public IEnumerable<Models.OrgTeam> TeamList { get { return Data.Organization.Teams.Where(x => x.ManagerID == this.ID); } }

        /// <summary>
        /// Gets the total GP earning modifier from all rooms and teams under this manager
        /// </summary>
        public Int64 Org_Earn_GP
        {
            get
            {
                return RoomList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_GP) +
                    TeamList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_GP);
            }
        }

        /// <summary>
        /// Gets the total Goods earning modifier from all rooms and teams under this manager
        /// </summary>
        public Int64 Org_Earn_Goods
        {
            get
            {
                return RoomList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Goods) +
                    TeamList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Goods);
            }
        }

        /// <summary>
        /// Gets the total Influence earning modifier from all rooms and teams under this manager
        /// </summary>
        public Int64 Org_Earn_Influence
        {
            get
            {
                return RoomList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Influence) +
                    TeamList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Influence);
            }
        }

        /// <summary>
        /// Gets the total Labor earning modifier from all rooms and teams under this manager
        /// </summary>
        public Int64 Org_Earn_Labor
        {
            get
            {
                return RoomList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Labor) +
                    TeamList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Labor);
            }
        }

        /// <summary>
        /// Gets the total Magic earning modifier from all rooms and teams under this manager
        /// </summary>
        public Int64 Org_Earn_Magic
        {
            get
            {
                return RoomList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Magic) +
                    TeamList.Where(e => e.DaysRemaining == 0).Sum(e => e.Earn_Magic);
            }
        }

        public Int64 Room_Count
        {
            get
            {
                return RoomList.Sum(e => e.Quantity);
            }
        }

        public Int64 Team_Count
        {
            get
            {
                return TeamList.Sum(e => e.Quantity);
            }
        }

        /// <summary>
        /// Gets to total time, in days, to finish constructing rooms
        /// Checks the parallel flag to determine if build times are parallel or sequential
        /// </summary>
        public Int64 ConstructionDaysRemaining
        {
            get
            {
                if (RoomList.Count() > 0)
                {
                    if (Data.Organization.Parallel)
                    {
                        return RoomList.Where(e => e.Paid == true).Select(e => e.DaysRemaining).DefaultIfEmpty(0).Max();
                    }
                    else
                    {
                        return RoomList.Where(e => e.Paid == true).Select(e => e.DaysRemaining).DefaultIfEmpty(0).Sum();
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets to total time, in days, to finish training teams
        /// Checks the parallel flag to determine if build times are parallel or sequential
        /// </summary>
        public Int64 RecruitmentDaysRemaining
        {
            get
            {
                if (TeamList.Count() > 0)
                {
                    if (Data.Organization.Parallel)
                    {
                        return TeamList.Where(e => e.Paid == true).Select(e => e.DaysRemaining).DefaultIfEmpty(0).Max();
                    }
                    else
                    {
                        return TeamList.Where(e => e.Paid == true).Select(e => e.DaysRemaining).DefaultIfEmpty(0).Sum();
                    }
                }
                else
                {
                    return 0;
                }

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
                return RoomList.Sum(e => e.Cost_GP) +
                       TeamList.Sum(e => e.Cost_GP);
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
                return RoomList.Sum(e => e.Cost_Goods) +
                       TeamList.Sum(e => e.Cost_Goods);
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
                return RoomList.Sum(e => e.Cost_Influence) +
                       TeamList.Sum(e => e.Cost_Influence);
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
                return RoomList.Sum(e => e.Cost_Labor) +
                       TeamList.Sum(e => e.Cost_Labor);
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
                return RoomList.Sum(e => e.Cost_Magic) +
                       TeamList.Sum(e => e.Cost_Magic);
            }
        }

    }
}
