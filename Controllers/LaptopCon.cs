using CoreApp.Models;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreApp.Controllers
{
    public class LaptopCon : Controller
    {
        Context c = new Context();
        LaptopRepository laptopRepository = new LaptopRepository();
        public IActionResult Index()
        {
            var result = laptopRepository.Tlist();
            return View(result);
        }
        public IActionResult DeleteLaptop(int id)
        {
            var result = c.Laptops.Find(id);
            laptopRepository.TDelete(result);
            return RedirectToAction("Index");
        }
      




       
        [HttpPost]
        public IActionResult AddLaptop(Laptop p)
        {
            laptopRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddLaptop()
        {
            return View();
        }


   [HttpGet]
        public IActionResult LaptopGet(int id)
        {
            var Result = laptopRepository.TGet(id);
            Laptop a = new Laptop()
            {
                ID = Result.ID,
                Brand = Result.Brand,
                Model = Result.Model,
                PurchasePrice = Result.PurchasePrice,
                SalePrice = Result.SalePrice,
                DiscountPrice = Result.DiscountPrice,
                Barcode = Result.Barcode
            };
            return View(a);
        }

        [HttpPost]
        public IActionResult LaptopUpdate(Laptop a)
        {
            var x = laptopRepository.TGet(a.ID);
            x.ID = a.ID;
            x.Brand = a.Brand;
            //x.Model = a.Model;
            //x.PurchasePrice = a.PurchasePrice;
            //x.SalePrice = a.SalePrice;
            //x.DiscountPrice = a.DiscountPrice;
            //x.Barcode = a.Barcode;
        
           laptopRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    


    }
}
