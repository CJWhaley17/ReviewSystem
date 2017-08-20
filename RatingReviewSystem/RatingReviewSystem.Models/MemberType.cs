using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingReviewSystem.Models
{
    public class MemberType
    {
        public int MemberTypeId { get; set; }

        public string MemberTypeName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}
