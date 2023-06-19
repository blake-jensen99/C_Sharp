using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers;

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
        List<Product> allProducts = _context.Products.ToList();
        return View("Index", allProducts);
    }

    [HttpPost("products/create")]
    public IActionResult CreateProduct(Product newProd)
    {
        if (!ModelState.IsValid)
        {
        List<Product> allProducts = _context.Products.ToList();
            return View("Index", allProducts);
        }
        else
        {
            _context.Add(newProd);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    
    [HttpGet("products/{id}")]
    public IActionResult OneProd(int id)
    {
        Product? oneProd = _context.Products.Include(p => p.pAssociation).ThenInclude(a=> a.Category).FirstOrDefault(p => p.ProductId == id);
        ViewBag.cats = _context.Categories.ToList();
        return View("OneProd", oneProd);
    }

    [HttpPost("products/add/category")]
    public IActionResult AddCatToProd(Association newAss)
    {
        _context.Add(newAss);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
