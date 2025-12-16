using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}