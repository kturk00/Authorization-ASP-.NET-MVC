using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectCRUD.Models;

namespace ProjectCRUD.Validators
{
    public class CustomDateValidator : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var book = (Book)validationContext.ObjectInstance;
            DateTime date = book.ReleaseDate;
            if (date < DateTime.Now)
                return ValidationResult.Success;
            return new ValidationResult("Date must not be a future one");
        }
    }
}
