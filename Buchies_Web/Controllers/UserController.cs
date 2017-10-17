using System;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;
using System.Net;
using System.Data.Entity;
using System.Threading.Tasks;
using Buchies_Service;
using Buchies_Web.Models;
using AutoMapper;

namespace Buchies_Web.Controllers
{
    public class UserController : Controller
    {

        public UserController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            BuchiesRepo repo = new BuchiesRepo();
            List<UserViewModel> Users = Mapper.Map<List<User>, List<UserViewModel>>(repo.GetUsers());
            return Json(Users, JsonRequestBehavior.AllowGet);
        }
        
        [HttpGet]
        public ActionResult CreateUser()
        {
            UserViewModel m = new UserViewModel();
            return PartialView("_CreateUser");
        }
    }
}