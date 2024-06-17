// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.ComponentModel.DataAnnotations;

namespace ProtectedWeb.Attributes.Validations.User
{
    public class UniqueEmail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dbContext = (SneakersContext)validationContext.GetService(typeof(SneakersContext));
            var isEmailUnique = !dbContext.Users.Any(u => u.Email == (string)value);

            if (!isEmailUnique)
            {
                return new ValidationResult("Email должен быть уникальным");
            }

            return ValidationResult.Success;
        }
    }
}
