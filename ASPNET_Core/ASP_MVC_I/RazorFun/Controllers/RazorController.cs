
using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers;
public class RazorController : Controller
{

    [HttpGet("")]
    public ViewResult ViewPage()
    {
        return View("Index");
    }
    
}