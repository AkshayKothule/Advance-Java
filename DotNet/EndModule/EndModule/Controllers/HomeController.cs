using System.Diagnostics;
using EndModule.Model;
using Microsoft.AspNetCore.Mvc;

namespace EndModule.Controllers
{
    public class HomeController : Controller
    {

        ProductDAL dalobj = new ProductDAL();

        public IActionResult Index()
        {
            List<Product> product = dalobj.getProduct();

            return View(product);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Product product)
        {


            if (ModelState.IsValid)
            {
                int rowaffected = dalobj.addProduct(product);


               return  Redirect("/Home/Index");

            }
            
                return View(product);


        }

//Edit

        public IActionResult Edit(int Id)
        {
            Product product = dalobj.getSingleProduct(Id);

            return View(product);

        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            dalobj.updateProduct(product);

            //if (rowaffected > 0)
            //{
            //    return Redirect("/Home/Index");
            //}
            return Redirect("/Home/Index");


        }

        //delete
        public IActionResult Delete(int id)
        {
            
            dalobj.deleteProduct(id);
            return Redirect("/Home/Index");

        }



    }
}
