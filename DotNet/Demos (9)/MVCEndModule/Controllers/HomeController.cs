using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCEndModule.Models;

namespace MVCEndModule.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}

 