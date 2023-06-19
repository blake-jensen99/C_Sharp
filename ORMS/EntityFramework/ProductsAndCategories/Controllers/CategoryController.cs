using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;
    private MyContext _context;

    public CategoryController(ILogger<CategoryController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("categories")]
    public IActionResult AllCategories()
    {
        List<Category> allCategories = _context.Categories.ToList();
        return View("Categories", allCategories);
    }

    [HttpPost("categories/create")]
    public IActionResult CreateCategory(Category newCat)
    {
        if (!ModelState.IsValid)
        {
        List<Category> allCategories = _context.Categories.ToList();
            return View("Categories", allCategories);
        }
        else
        {
            _context.Add(newCat);
            _context.SaveChanges();
            return RedirectToAction("AllCategories");
        }
    }

    [HttpGet("categories/{id}")]
    public IActionResult OneCat(int id)
    {
        Category? oneCat = _context.Categories.Include(p => p.cAssociation).ThenInclude(a=> a.Product).FirstOrDefault(p => p.CategoryId == id);
        ViewBag.prods = _context.Products.ToList();
        return View("OneCat", oneCat);
    }

    [HttpPost("categories/add/product")]
    public IActionResult AddProdToCat(Association newAss)
    {
        _context.Add(newAss);
        _context.SaveChanges();
        return RedirectToAction("AllCategories");
    }

}
