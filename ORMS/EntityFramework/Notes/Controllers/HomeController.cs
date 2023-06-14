using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Notes.Models;

namespace Notes.Controllers;

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
        return View();
    }

    [HttpGet("monsters/all")]
    public IActionResult AllMonsters()
    {
        ViewBag.AllMonsters = _context.Monsters.ToList();
        ViewBag.Tallest = _context.Monsters.OrderByDescending(m => m.Height).First();
        
        return View("AllMonsters");
    }

    [HttpGet("monsters/{id}")]
    public IActionResult ShowMonster(int id)
    {
        Monster? OneMonster = _context.Monsters.FirstOrDefault(m => m.MonsterId == id);
        return View("OneMonster", OneMonster);
    }

    [HttpPost("monsters/create")]
    public IActionResult CreateMonster(Monster newMon)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newMon);
            _context.SaveChanges();
            return RedirectToAction("AllMonsters");
        }
        else 
        {
            return View("Index");
        }
    }

    // 1. Trigger a post request that contains the updated instance from our form and the ID of that instance
    [HttpPost("monsters/{MonsterId}/update")]
    public IActionResult UpdateMonster(Monster newMon, int MonsterId)
    {
        // 2. Find the old version of the instance in your database
        Monster? OldMonster = _context.Monsters.FirstOrDefault(i => i.MonsterId == MonsterId);
        // 3. Verify that the new instance passes validations
        if(ModelState.IsValid)
        {
            #pragma warning disable CS8602
            // 4. Overwrite the old version with the new version
            // Yes, this has to be done one attribute at a time
            OldMonster.Name = newMon.Name;
            OldMonster.Height = newMon.Height;
            OldMonster.Description = newMon.Description;
            // You updated it, so update the UpdatedAt field!
            OldMonster.UpdatedAt = DateTime.Now;
            // 5. Save your changes
            _context.SaveChanges();
            // 6. Redirect to an appropriate page
            return RedirectToAction("AllMonsters");
        } else {
            // 3.5. If it does not pass validations, show error messages
            // Be sure to pass the form back in so you don't lose your changes
            // It should be the old version so we can keep the ID
            return View("OneMonster", OldMonster);
        }
    }

    [HttpPost("monsters/{MonsterId}/destroy")]
    public IActionResult DestroyMonster(int MonsterId)
    {
        Monster? MonToDelete = _context.Monsters.SingleOrDefault(i => i.MonsterId == MonsterId);
        // Once again, it could be a good idea to verify the monster exists before deleting
        _context.Monsters.Remove(MonToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
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
