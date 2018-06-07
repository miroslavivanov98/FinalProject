using FinalProject.Repositories;
using FinalProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FinalProject.Web.Controllers
{
    public class WeaponController : Controller
    {
        private readonly UnitOfWork uow;
        public WeaponController()
        {
            uow = new UnitOfWork(new DataAccess.FinalProjectDbContext());
        }

        // GET: Weapon
        public ActionResult Index()
        {
            return RedirectToAction("View");
        }
        public ActionResult View(int id)
        {
            try
            {
                WeaponViewModel model = new WeaponViewModel(new WeaponRepository().GetByID(id));
                if (model.Weapon == null)
                {
                    //product not found
                    return RedirectToAction("Error404", "Error");
                }
                return View(model);
            }
            catch (Exception e) { return RedirectToAction("Error404", "Error"); }
        }

        public ActionResult List(int page = 0)
        {
            WeaponListViewModel model = new WeaponListViewModel() { Weapon = uow.WeaponRepository.GetAll() };

            return View(model);
        }
    }
}