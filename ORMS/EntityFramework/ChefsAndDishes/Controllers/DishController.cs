using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Controllers;

public class DishController : Controller
{
    private readonly ILogger<DishController> _logger;

    private MyContext _context;

    public DishController(ILogger<DishController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("dishes/all")]
    public IActionResult AllDishes()
    {
        List<Dish> AllDishes = _context.Dishes.Include(c => c.Creator).ToList();
        return View("AllDishes", AllDishes);
    }

    [HttpGet("dishes/new")]
    public IActionResult NewDish()
    {
        ViewBag.chefs = _context.Chefs.ToList();
        return View("NewDish");
    }

    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.chefs = _context.Chefs.ToList();

            return View("NewDish");
        }
        else
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("AllDishes");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
