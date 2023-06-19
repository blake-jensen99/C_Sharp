#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;
public class Product 
{
    [Key]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Name is Required")]
    public string Name { get; set; } 

    [Required(ErrorMessage = "Description is Required")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "Price is Required")]
    public int? Price { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Association> pAssociation {get;set;} = new List<Association>();
}
