using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context; 

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        ViewBag.AllDishes = _context.Dishes.ToList();
        return View();
    }

    [HttpGet("dishes/add")]
    public IActionResult Add()
    {
        return View("Add");
    }

    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else 
        {
            return View("Add");
        }
    }

    [HttpGet("dishes/{id}")]
    public IActionResult ShowDish(int id)
    {
        Dish? OneDish = _context.Dishes.FirstOrDefault(m => m.DishId == id);
        return View("One", OneDish);
    }

    [HttpPost("dishes/{DishId}/destroy")]
    public IActionResult DestroyDish(int DishId)
    {
        #pragma warning disable CS8604
        Dish? DishToDelete = _context.Dishes.SingleOrDefault(i => i.DishId == DishId);
        _context.Dishes.Remove(DishToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet("dishes/{id}/edit")]
    public IActionResult EditDish(int id)
    {
        Dish? OneDish = _context.Dishes.FirstOrDefault(m => m.DishId == id);
        Console.WriteLine(OneDish.Name);
        return View("Edit", OneDish);
    }

    [HttpPost("dishes/{id}/update")]
    public IActionResult UpdateDish(Dish newDish, int id)
    {
        Dish? OldDish = _context.Dishes.FirstOrDefault(i=> i.DishId == id);
        if (ModelState.IsValid)
        {
            #pragma warning disable CS8602

            OldDish.Name = newDish.Name;
            OldDish.Chef = newDish.Chef;
            OldDish.Tastiness = newDish.Tastiness;
            OldDish.Calories = newDish.Calories;
            OldDish.Description = newDish.Name;
            OldDish.UpdatedAt = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction("Index");
        } 
        else 
        {
            return View("Edit", OldDish);
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
