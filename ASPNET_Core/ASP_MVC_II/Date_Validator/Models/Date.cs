#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Date_Validator.Models;

public class Date
{
    [Required(ErrorMessage = "Date Required")]
    [NoFuture]
    public DateTime PastDate {get;set;}
}




public class NoFutureAttribute : ValidationAttribute
{  
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)    
    {    
        if ((DateTime)value > DateTime.Now)
        {           
            return new ValidationResult("Date cannot be in the future");   
        } else {     
            return ValidationResult.Success;  
        }  
    }
}