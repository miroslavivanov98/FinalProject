using FinalProject.DB.Entities;
using FinalProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WeaponRepository weapons = new WeaponRepository();
            Weapon neshtosi = new Weapon() { Id = 0, ManafacturerId = 2, Weight = "2,50kg", Name = "Nehsto", Price = "1999лв" };
            weapons.Save(neshtosi);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}