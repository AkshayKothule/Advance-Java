using Microsoft.AspNetCore.Mvc;
using MVCLab.Filters;
using MVCLab.Models;

namespace MVCLab.Controllers;
[LogFilter]
public class HomeController : Controller
{
    StudentViewModel svm=new StudentViewModel();
    // GET
    [AuthFilter]
    public IActionResult Index()
    {
        ViewBag.Title = "Home";
        ViewBag.UserName = GetUserName();
        List<Student> students = svm.GetStudents();
        return View(students);
       
    }
    
    //create
    [AuthFilter]
    public IActionResult Create()
    {
        return View();
        
    }
  [AuthFilter]
  [HttpPost]
    public IActionResult Create(Student student)
    {
        if (ModelState.IsValid)
        {
            svm.AddStudent(student);
            return Redirect("/Home/Index");
        }
        else
        {
            return View(student);
        }
        
    }
    
    
    //edit
    [AuthFilter]
    public IActionResult Edit(int id)
    {
        Student student = svm.GetStudent(id);
        return View(student);
        
    }
    [AuthFilter]
    [HttpPost]
    public IActionResult Edit(Student updatedStudent)
    {
        if (ModelState.IsValid)
        {
            int rowsaffected= svm.UpdateStudent(updatedStudent);

            if (rowsaffected > 0)
            {
                return Redirect("/Home/Index");
                
            }
            else
            {
                
                ViewBag.Message = "Failed to update record";
                return View(updatedStudent);
                
            }
           
            
        }else
        {
            ViewBag.Message="something is not right with data";
            return View(updatedStudent);
        }
        
    }
    
    
    
    
    //delete
    public IActionResult Delete(int id)
    {
        
        svm.DeleteStudent(id);
        return Redirect("/Home/Index");
    }
    
   

    
    
    public IActionResult About()
    {
        ViewBag.Title = "About";
        ViewBag.UserName = GetUserName();
        return View();
    }
    public IActionResult Contact()
    {
        ViewBag.Title = "Contact Us";
        ViewBag.UserName = GetUserName();
        return View();
    }
    
    private string GetUserName()
    {
        if (HttpContext.Session.GetString("UserName") != null && HttpContext.Session.GetString("UserName") == "")
        {
            return HttpContext.Session.GetString("UserName");
            
        }
        else
        {
            return "Guest";
        }
    }
   
}