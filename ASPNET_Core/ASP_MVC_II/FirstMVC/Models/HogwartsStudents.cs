#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstMVC.Models;

public class HogwartsStudent
{
    [Required(ErrorMessage = "Name is required.")]
    [NoZNames]
    public string Name {get;set;}
    [Required(ErrorMessage = "House is required.")]
    public string House {get;set;}
    [Required(ErrorMessage = "Year is required.")]
    [Range(1, 5, ErrorMessage = "Year must be 1 through 5")]
    public int CurrentYear {get;set;}
}

public class NoZNamesAttribute : ValidationAttribute
{  
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   if (value == null) 
    {
        return new ValidationResult("No Z names");
    }
        if (((string)value).ToLower()[0] == 'z')
        {           
            return new ValidationResult("No names that start with Z allowed!");   
        } else {     
            return ValidationResult.Success;  
        }  
    }
}