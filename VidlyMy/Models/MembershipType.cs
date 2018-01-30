using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMy.Models
{
    public class MembershipType
    {
        [Required]
        public byte Id { get; set; }
        public short SignUpFree { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
        public string MembershipTypeName { get; set; }
        
    }
}