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
        private readonly UnitOfWork uow;
        public HomeController()
        {
            uow = new UnitOfWork(new DataAccess.FinalProjectDbContext());
        }
        public ActionResult Index()
        {
           
            Weapon Rifle = new Weapon() { Id = 0, ManafacturerId = 1, Model = "Rifle", Caliber = "12", Weight = "2.1kg", BarrelLength = "90См", Price = "1245" };
            //uow.WeaponRepository.Save(Rifle);          

            WeaponListViewModel model = new WeaponListViewModel() { Weapon = uow.WeaponRepository.GetAll() };
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