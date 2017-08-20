using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingReviewSystem.Models
{
    public class ChapterType
    {
        public int ChapterTypeId { get; set; }

        public string ChapterTypeName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}
