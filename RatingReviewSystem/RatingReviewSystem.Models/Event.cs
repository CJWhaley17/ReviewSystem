using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingReviewSystem.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public int ChapterId { get; set; }

        public DateTime EventDateTime { get; set; }

        public string EventName { get; set; }

        public string EventDescription { get; set; }

        public int EventLeadMemberId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }


    }
}
