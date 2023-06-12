#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models;

public class User 
{
    [Required(ErrorMessage = "Name is required")]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters long")]
    public string Name {get;set;}

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Format")]
    public string Email {get;set;}

    [Required(ErrorMessage = "Date of birth is required")]
    [NoFuture]
    public DateTime? DOB {get;set;}

    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at last 8 characters long")]
    public string Password {get;set;}

    [Required(ErrorMessage = "Favorite prime number is required")]
    [Prime]
    public int? FPN {get;set;}
}


public class NoFutureAttribute : ValidationAttribute
{  
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {    if (value == null) {
        return new ValidationResult("Must select a date");
    }
        else if ((DateTime)value > DateTime.Now)
        {           
            return new ValidationResult("Date cannot be in the future");   
        } else {     
            return ValidationResult.Success;  
        }  
    }
}

public class PrimeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null) 
        {
        return new ValidationResult("Must select a date");
        }
        bool isPrime = true;
        int num = (int)value;
        for (int i = 2; i < num / 2; i++)
        {
            if (num % i == 0) 
            {
                isPrime = false;
                break;
            }
        }
        if (!isPrime)
        {
            return new ValidationResult("Number must be prime");
        }
        return ValidationResult.Success;

    }
}