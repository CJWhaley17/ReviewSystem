using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingReviewSystem.Models
{
    public class OrganizationLeadership
    {
        public Ambassador Ambassador { get; set; }
        public VPMembership VPMembership { get; set; }
        public VPMedia VPMedia { get; set; }
        public EventCoordinator1 EventCoordinator1 { get; set; }
        public EventCoordinator2 EventCoordinator2 { get; set; }
        public Treasurer Treasurer { get; set; }
        public Secretary Secretary { get; set; }
        public string College { get; set; }
    }
}
