
using Microsoft.AspNetCore.Mvc;

namespace Portfolio2.Controllers;
public class Portfolio2Controller : Controller
{
         
    [HttpGet("")] 
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("projects")]
    public ViewResult Projects()
    {
        return View("Projects");
    }


    [HttpGet("contact")]
    public ViewResult Contact()
    {
        return View("Contact");
    }
}