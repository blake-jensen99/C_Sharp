
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;
public class HelloController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "Hello World from HelloController!";
    }

    [HttpGet("greet/{name}")]
    public string Greet(string name)
    {
        return $"Hello {name}!";
    }

    [HttpGet("view")]
    public ViewResult ViewPage()
    {
        ViewBag.dog = "Duke";
        return View("Index");
    }

    [HttpGet("redirect")]
    public RedirectResult Redirect()
    {
        return Redirect("/view");
    }


    [HttpGet("result/{favoriteResponse}")]
    public IActionResult ItDepends(string favoriteResponse)
    {
        if (favoriteResponse == "Redirect")
        {
            return RedirectToAction("Index");
        }
        else if (favoriteResponse == "Json")
        {
            return Json(new { favoriteResponse = favoriteResponse });
        }
        else
        {
            // This route will require that an "ItDepends.cshtml" exists
            return View();
        }
    }


    [HttpPost("process")]
    public IActionResult Process(string TextField, int NumberField)
    {
        // Do something with form input
        Console.WriteLine($"My text was: {TextField}");
        Console.WriteLine($"My number was: {NumberField}");
        return RedirectToAction("Index");
    }
}

