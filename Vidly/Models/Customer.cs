﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter customer Name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display( Name = "Member sheep")]
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Day of birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}