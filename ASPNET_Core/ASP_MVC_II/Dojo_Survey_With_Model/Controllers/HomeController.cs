using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_With_Model.Models;

namespace Dojo_Survey_With_Model.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    // [HttpGet("results")]
    // public IActionResult Results()
    // {
    //     return View("Results");
    // }

    [HttpPost("form")]
    public IActionResult Form(Survey user)
    {
        if(ModelState.IsValid) 
        {
            Survey example = user;
            return View("Results", example);
        }
        else 
        {
            return View("Index");
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
