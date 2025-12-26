using EndModule.Model;
using Microsoft.AspNetCore.Mvc;

namespace EndModule.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult SignIn()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SignIn(LoginUser user)
    {
        if (ModelState.IsValid)
        {
            if (user.Name == "admin" && user.Password == "admin123")
            {
                HttpContext.Session.SetString("Name" , user.Name);
                return Redirect("/Home/Index");
            }
        }
        
        return View(user);
        
    }

    public IActionResult SignOut()
    {
        HttpContext.Session.Remove("Name");
       return  Redirect($"/Login/SignIn");
    }
}