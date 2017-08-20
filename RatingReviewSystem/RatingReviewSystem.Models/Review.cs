using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingReviewSystem.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        // this one can be for either EventId or LeaderId
        // depends on ReviewTypeId
        public int SubjectId { get; set; }

        public int ReviewTypeId { get; set; }

        public int ReviewRating { get; set; }

        public bool ReviewIsVibile { get; set; }

        public DateTime ReviewDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}
