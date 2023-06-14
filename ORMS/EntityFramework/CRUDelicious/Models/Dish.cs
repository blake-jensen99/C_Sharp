#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;

public class Dish
{
    [Key]
    public int DishId {get; set;}

    [Required(ErrorMessage = "Name is required")]
    public string Name {get; set;}

    [Required(ErrorMessage = "Chef is required")]
    public string Chef {get; set;}

    [Required(ErrorMessage = "Tastiness is required")]
    [Range(1,6, ErrorMessage = "Tastiness must be between 1 and 5")]
    public int Tastiness {get; set;}

    [Required(ErrorMessage = "Calories are required")]
    [Range(0,int.MaxValue, ErrorMessage = "Calories must be more than 0")]
    public int? Calories {get; set;}

    [Required(ErrorMessage = "Description is required")]
    public string Description {get; set;}

    public DateTime CreatedAt {get; set;} = DateTime.Now;

    public DateTime UpdatedAt {get; set;} = DateTime.Now;
}

