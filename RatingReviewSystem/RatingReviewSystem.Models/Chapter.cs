using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingReviewSystem.Models
{
    public class Chapter
    {
        public int ChapterId { get; set; }

        public string ChapterName { get; set; }

        public int ChapterTypeId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}
