using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;

namespace SessionWorkshop.Controllers;

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
        // HttpContext.Session.Clear();
        return View();
    }

    [HttpPost("register")]
    public IActionResult Register(string Name)
    {
        if (Name == null)
        {
            return RedirectToAction("Index");
        }
        HttpContext.Session.SetString("UserName", Name);
        HttpContext.Session.SetInt32("Num", 22);

        return RedirectToAction("Dash");
    }



    [HttpGet("dash")]
    public IActionResult Dash()
    {
        if (HttpContext.Session.GetString("UserName") == null)
        {
            return RedirectToAction("Index");
        }
        return View("Dash");
    }


    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost("alter")]
    public IActionResult Alter(int val)
    {
        
        if (val == 1)
        {

            int num = (int)HttpContext.Session.GetInt32("Num") + 1;
            HttpContext.Session.SetInt32("Num", num);

        }
        else if (val == 2)
        {
            int num = (int)HttpContext.Session.GetInt32("Num") - 1;
            HttpContext.Session.SetInt32("Num", num);
        }
        else if (val == 3)
        {
            int num = (int)HttpContext.Session.GetInt32("Num") * 2;
            HttpContext.Session.SetInt32("Num", num);
        }
        else if (val == 4)
        {
            Random rand = new Random();
            int num = (int)HttpContext.Session.GetInt32("Num") + rand.Next(1,11);
            HttpContext.Session.SetInt32("Num", num);
        }
        
        return RedirectToAction("Dash");
    }


}
