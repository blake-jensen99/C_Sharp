
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers;
public class Portfolio : Controller
{
    [HttpGet]     
    [Route("")] 
    public string Index()
    {
        return "This is my Index!";
    }

    [HttpGet("projects")]
    public string Projects(string name)
    {
        return "These are my projects!";
    }


    [HttpGet("contact")]
    public string Contact(string name)
    {
        return "This is my Contact!";
    }
}