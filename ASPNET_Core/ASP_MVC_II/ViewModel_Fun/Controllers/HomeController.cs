using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers;

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
        string message = "I am a message from the other said of the vail.";
        return View("Index", message);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
        int[] numbers = new int[6] {1,2,3,4,5,6};
        return View("Numbers", numbers);
    }

    [HttpGet("user")]
    public IActionResult OneUser()
    {
        User Donnie = new User()
        {
            FirstName = "Donnie",
            LastName = "Dingle"
        };
        return View("OneUser", Donnie);
    }

    [HttpGet("allusers")]
    public IActionResult AllUsers()
    {
        List<User> AllUsers = new List<User>();
        User Donnie = new User() {FirstName = "Donnie", LastName = "Dingle"};
        AllUsers.Add(Donnie);
        User Rudy = new User() {FirstName = "Rudy", LastName = "Johns"};
        AllUsers.Add(Rudy);
        User Mack = new User() {FirstName = "Mack", LastName = "Truck"};
        AllUsers.Add(Mack);
        User Emily = new User() {FirstName = "Emily", LastName = "Jeffersonsonsonson"};
        AllUsers.Add(Emily);
        User Tonya = new User() {FirstName = "Tonya", LastName = "Tucker"};
        AllUsers.Add(Tonya);
        return View("AllUsers", AllUsers);
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
