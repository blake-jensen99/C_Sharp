#pragma warning disable CS8618
#pragma warning disable CS8603
#pragma warning disable CS8765
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChefsAndDishes.Models;
public class Chef 
{
    [Key]
    public int ChefId { get; set; }

    [Required(ErrorMessage = "First name is Required")]
    [Display(Name =  "First Name")]
    public string FirstName { get; set; } 

    [Required(ErrorMessage = "Last name is Required")]
    [Display(Name =  "Last Name")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Date of Birth is Required")]
    [NoFuture]
    [Display(Name = "Date of Birth")]
    public DateTime? DOB { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Dish> AllDishes { get; set; } = new List<Dish>();
}

public class NoFutureAttribute : ValidationAttribute
{  
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)    
    {    
        if (value == null)
        {
            return new ValidationResult("Date is required");
        }
        else if ((DateTime)value > DateTime.Now)
        {           
            return new ValidationResult("Date cannot be in the future");   
        } else {     
            return ValidationResult.Success;  
        }  
    }
}