using CoreApp.Models;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Controllers
{
    public class TvCon : Controller
    {
        Context c = new Context();
        TvRepository tvRepository = new TvRepository();
        public IActionResult Index()
        {
            var result = tvRepository.Tlist();
            return View(result);
        }
        //public IActionResult DeleteTv(int id)
        //{
        //    var a = c.Tvs.Find(id);
        //    tvRepository.TDelete(a);
        //    return RedirectToAction("Index");
        //}

        public IActionResult TvDelete(int id)
        {
            var a = c.Tvs.Find(id);
            tvRepository.TDelete(a);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddTv(Tv p)
        {
            tvRepository.TAdd(p);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddTV()
        {
            return View();
        }

        public IActionResult TVGet(int id)
        {
            var Result = tvRepository.TGet(id);
            Tv a = new Tv()
            { ID = Result.ID,
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
        public IActionResult TvUpdate(Laptop a)
        {
            var x = tvRepository.TGet(a.ID);
            x.ID = a.ID;
            x.Brand = a.Brand;
            x.Model = a.Model;
            x.PurchasePrice = a.PurchasePrice;
            x.SalePrice = a.SalePrice;
            x.DiscountPrice = a.DiscountPrice;
            x.Barcode = a.Barcode;
         
            tvRepository.TUpdate(x);
            return RedirectToAction("Index");
        }



    }
}
