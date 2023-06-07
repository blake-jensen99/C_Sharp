
using Microsoft.AspNetCore.Mvc;

namespace Countdown.Controllers;
public class CountdownController : Controller    
{

    [HttpGet("")] 
    public ViewResult Index()
    {
        DateTime CurrentTime = DateTime.Now;
        DateTime EndDate = new DateTime(2023, 9, 17);
        TimeSpan Difference = (EndDate - CurrentTime);
        ViewBag.CurrentTime = CurrentTime.ToString("dddd, dd MMMM yyyy");
        ViewBag.EndDate = EndDate.ToString("dddd, dd MMMM yyyy");
        ViewBag.Difference = Difference;
        return View("Index");
    }

}
