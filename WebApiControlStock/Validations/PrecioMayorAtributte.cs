using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiControlStock.Validations
{
    public class PrecioMayorAtributte: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int precio = (int)value;

            if (precio <= 0)
            {
                return new ValidationResult("Solo se aceptan precios mayores a cero");
            }
            return ValidationResult.Success;

        }
    }
}
   