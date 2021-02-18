using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectCRUD.Models;

namespace ProjectCRUD.Validators
{
    public class CodeValidator : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var author = (Author)validationContext.ObjectInstance;
            string code = author.Code;
            if (author.LastName.Substring(0, 2).Equals(code.Substring(0, 2), StringComparison.InvariantCultureIgnoreCase) 
                && code.Length == 6 && IsDigitsOnly(code))
                return ValidationResult.Success;
            return new ValidationResult("Code must consist of 2 first letters of last name followed by 4 digits");
        }

        bool IsDigitsOnly(string str)
        {
            string sub = str.Substring(2, 4);
            return sub.All(c => c >= '0' && c <= '9');
        }
    }
}
