using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
public class DataController : Controller
{
    public IActionResult Greet()
    {
        ViewBag.FirstName = "Binamra";
        ViewBag.LastName = "Kafle";

        ViewData["FirstName"] = "Binamra";
        ViewData["LastName"] = "Kafle";

        TempData["FirstName"] = "Binamra";
        TempData["LastName"] = "Kafle";

        var person = new Person { FirstName = "Binamra", LastName = "Kafle" };

        return View(person);
    }

    public IActionResult QueryGreet(string firstName, string lastName)
    {
        ViewBag.FirstName = firstName;
        ViewBag.LastName = lastName;
        return View();
    }

    public IActionResult DisplayFruits()
    {
        string[] fruits = { "Apple", "Banana", "Mango", "Orange" };
        return View(fruits);
    }
}