using AutoMapper;
using Buchies_Service;
using Buchies_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.Mvc;

namespace Buchies_Web.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetProducts()
        {
            BuchiesRepo repo = new BuchiesRepo();
            List<ProductViewModel> product = Mapper.Map<List<Product>, List<ProductViewModel>>(repo.GetProducts());
            return Json(product, JsonRequestBehavior.AllowGet);
        }


        public ActionResult SaveProducts()
        {
            return View();
        }

        public ActionResult GetUsers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult SaveUsers()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}