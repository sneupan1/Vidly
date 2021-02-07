using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Vidly.Dtos;

namespace Vidly.Models
{
    public class CustomValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId== MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is required");
            var customerYear = Regex.Match(customer.BirthDate, @"\b\d{4}\b").Value;
            Console.WriteLine(customerYear);
            var age = long.Parse(DateTime.Today.Year.ToString()) - long.Parse(customerYear);

            return (age >=18)
                ? ValidationResult.Success 
                : new ValidationResult("Customers should be atleast 18 years old to go on a membership");
        }
    }
}