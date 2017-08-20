using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingReviewSystem.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        public int ChapterId { get; set; }

        public int MemberTypeId { get; set; }
        
        public string MemberName { get; set; }

        public string MemberPhone { get; set; }

        public string MemberEmail { get; set; }

        public string PasswordHashed { get; set; }

        public string MemberIsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

    }
}
