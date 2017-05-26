using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Rental_Application.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var Customer = (Customer)validationContext.ObjectInstance;
            if (Customer.MembershipTypeId == MemberShipType.UnKnown || Customer.MembershipTypeId == MemberShipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (Customer.Birthdate == null)
            {
                return new ValidationResult("BirthDarte is required");
            }
            var age = DateTime.Today.Year - Customer.Birthdate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success :
                new ValidationResult("Customer should be atleast 18 Years Old to go on a membership.");
        }
    }
}