
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;
public class SurveyController : Controller
{

    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("results")]
    public ViewResult Results()
    {
        return View("Results");
    }

    [HttpPost("form")]
    public IActionResult Form(string Name, string Location, string Language, string Comment)
    {
        string none = "No Comment";
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        if (Comment == null)
        {
            ViewBag.Comment = none;
        }
        else
        {
            ViewBag.Comment = Comment;

        }
        return View("Results");
    }


}

