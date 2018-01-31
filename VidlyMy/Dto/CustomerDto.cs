using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyMy.Models;

namespace VidlyMy.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name!")]
        [StringLength(255)]
        public string Name { get; set; }


        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfAMember]
        public DateTime Birthdate { get; set; }

    }
}