using System;
using System.ComponentModel.DataAnnotations;

namespace MovieShop.MVC.Validators
{
    public class DateNotInPastAttribute : ValidationAttribute
    {
        public DateNotInPastAttribute()
        {
            ErrorMessage = "Purchase date cannot be in the past.";
        }

        public override bool IsValid(object? value)
        {
            if (value is DateTime date)
            {
                return date.Date >= DateTime.Today;
            }

            return true;
        }
    }
}