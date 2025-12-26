using Artitest.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;

namespace Artitest.Controllers
{
    public class HomeController : Controller
    {
        ArtitestDAL dalObj=new ArtitestDAL();
        
        public IActionResult Index()
        {
            List<Models.Artitest> artitest = dalObj.getAllArtitests();
            
            return View(artitest);
        }
        
        //create 
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.Artitest  artitest)
        {
           // if (ModelState.IsValid)
           // {
                dalObj.addArtitest(artitest);
                return Redirect("/Home/Index");
            //}
            
            //return View(artitest);
        }
        
        //update
        public IActionResult Edit(int id)
        {
            Models.Artitest aritest = dalObj.getArtiest(id);
            return View(aritest);
        }
        [HttpPost]
        public IActionResult Edit(Models.Artitest  artitest)
        {
            //dalObj.UpdateArtitest(artitest);
            if (ModelState.IsValid)
            {
                dalObj.UpdateArtitest(artitest);
                return Redirect("/Home/Index");
            }
            return View(artitest);
            
        }
      
        //delete
        public IActionResult Delete(int Id)
        {
            dalObj.DeleteArtitest(Id);
            return Redirect("/Home/Index");


        }
        
    }
    
}
