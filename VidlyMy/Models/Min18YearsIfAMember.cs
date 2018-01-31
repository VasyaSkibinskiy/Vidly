using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidlyMy.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId==MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
                return new ValidationResult("Need your age");

            var age = DateTime.Today.Year - customer.Birthdate.Year;
            return (age >=18) ? ValidationResult.Success : new ValidationResult("Just for 18+");
        }
    }
}