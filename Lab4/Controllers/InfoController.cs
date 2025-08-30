
using Microsoft.AspNetCore.Mvc;
public class InfoController : Controller
{
    public IActionResult About()
    {
        return View();
    }

    public IActionResult GoToPrivacy()
    {
        return RedirectToAction("Privacy", "Home");
    }

    public IActionResult ShowMessage()
    {
        return Content("This is a plain text message.");
    }

    public IActionResult GetJson()
    {
        var data = new { Name = "Binamra", Age = 20 };
        return Json(data);
    }

    public IActionResult GoToGoogle()
    {
        return Redirect("https://www.google.com");
    }

    public IActionResult DoNothing()
    {
        return new EmptyResult();
    }
}