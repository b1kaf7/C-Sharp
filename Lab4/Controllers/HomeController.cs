using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Greet(string name)
    {
        ViewBag.Name = name;
        return View();
    }

    public IActionResult DataExample()
    {
        ViewBag.FirstName = "Binamra";
        ViewData["LastName"] = "Kafle";
        TempData["FullName"] = "Binamra Kafle";

        var person = new Person { FirstName = "Binamra", LastName = "Kafle" };
        return View(person);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
