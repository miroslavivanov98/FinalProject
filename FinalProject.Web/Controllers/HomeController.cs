using FinalProject.DB.Entities;
using FinalProject.Repositories;
using FinalProject.Web.Models;
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
            //WeaponRepository weapons = new WeaponRepository();
            //Weapon AtaArms = new Weapon() { Id = 0, ManafacturerId = 3, Name = "Ms1020", Caliber = "12", Weight = "2.1kg", BarrelLength = "90См", Price = "1245лв" };
            //weapons.Save(AtaArms);
            //return View();
            WeaponRepository repo = new WeaponRepository();

            WeaponListViewModel model = new WeaponListViewModel() { Weapon = repo.GetAll() };
            return View(model);
           
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