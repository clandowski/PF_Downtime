using System;

namespace PF_Downtime.Models
{
    /// <summary>
    /// Represents the types of resources in the downtime system
    /// </summary>
    public class BaseResource
    {
        /// <summary>
        /// Unique identifier from database
        /// </summary>
        public Int64 Resource_ID { get; set; } = 0;
        /// <summary>
        /// Name of resource
        /// </summary>
        public String Name { get; set; } = "GP";
        /// <summary>
        /// Cost to earn the resource via normal resource generation
        /// </summary>
        public Int64 Cost_Earn { get; set; } = 0;

        /// <summary>
        /// Instantiates a resource object
        /// </summary>
        /// <param name="Resource_ID">Unique identifier from database</param>
        /// <param name="Name">Resource name</param>
        /// <param name="Cost_Earn">Cost to earn resource</param>
        public BaseResource(Int64 Resource_ID, String Name, Int64 Cost_Earn)
        {
            this.Resource_ID = Resource_ID;
            this.Name = Name;
            this.Cost_Earn = Cost_Earn;
        }

        /// <summary>
        /// Creates a blank resource record
        /// </summary>
        public BaseResource() {}

        /// <summary>
        /// Cost to purchase a resource.  Double the cost to earn.
        /// </summary>
        public Int64 Cost_Purchase
        {
            get
            {
                return (Int64)(Cost_Earn * 2);
            }
        }

        
    }
}