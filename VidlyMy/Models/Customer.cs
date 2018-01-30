﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMy.Models;
using System.ComponentModel.DataAnnotations;

namespace asp_les_1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}