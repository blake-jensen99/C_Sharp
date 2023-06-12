#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Dojo_Survey_With_Model.Models;

public class Survey 
{
    [Required(ErrorMessage = "Name is reqired.")]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]
    public string Name {get;set;}
    [Required]
    public string Location {get;set;}
    [Required]
    public string Language {get;set;}
    [MinLength(20, ErrorMessage = "Comment must be at least 20 characters long.")]
    public string? Comment {get;set;}
}