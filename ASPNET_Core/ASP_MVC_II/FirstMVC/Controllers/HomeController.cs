using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers;

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
        Friend MyFriend = new Friend()
        {
            FirstName = "Jeff",
            LastName = "Foxworthy",
            Age = 64
        };
        HttpContext.Session.SetString("Username", "Blake");
        HttpContext.Session.SetInt32("Num", 14);
        return View("Index", MyFriend);
    }

    [HttpGet("form")]
    public IActionResult Form()
    {
        return View("WizardForm");
    }

    [HttpPost("register")]
    public IActionResult RegisterWizard(HogwartsStudent student) // updated
    {    
        if(ModelState.IsValid)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View("WizardForm");
        }
    } 

    [HttpPost("addone")]
    public IActionResult AddOne(int val)
    {
        if (val == 1)
        {
            Console.WriteLine(val);
        }
        int num = (int)HttpContext.Session.GetInt32("Num") + 1;
        HttpContext.Session.SetInt32("Num", num);
        
        return RedirectToAction("Form");
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
