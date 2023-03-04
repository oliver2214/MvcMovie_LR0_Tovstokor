using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie_LR0_Tovstokor.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string name, int numtimes = 1)
    {
        ViewData["Message"] = name;
        ViewData["NumTimes"] = numtimes;
        return View();
    }
}