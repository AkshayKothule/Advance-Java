using Microsoft.AspNetCore.Mvc;
using MVCLab.Filters;
using MVCLab.Models;
namespace MVCLab.Controllers;
[LogFilter]
public class LoginController : Controller
{
    // GET
    public IActionResult SignIn()
    {
        ViewBag.Title = "Sign In here";
        ViewBag.UserName = "Geust";
        return View();
    }
    [HttpPost]
    public IActionResult SignIn(LoginUser user)
    {
        if(ModelState.IsValid)
        {
            if(user.UserName=="test" && user.Password=="test123")
            {
                HttpContext.Session.SetString("UserName", user.UserName);
                return Redirect("/Home/Index");

            }
            else
            {
                ViewBag.Message = "Credentials are incorrect!";
                return View(user);
            }
        }
        else
        {
            return View(user);
        }
    }
    
    public IActionResult SignOut()
    {
        HttpContext.Session.Remove("UserName");
        return Redirect($"/Login/SignIn");
     
    }
}