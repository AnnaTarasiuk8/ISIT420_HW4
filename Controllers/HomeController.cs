using ISIT420_HW4_Tarasiuk_Gurskaia.Models;
using ISIT420_HW4_Tarasiuk_Gurskaia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            DataService service = new DataService();
            List<CD> allCD = service.GetAllCD();
            List<SalesPerson> allSalesPerson = service.GetAllSalesPerson();
            List<Store> allStores = service.GetAllStores();
            ViewBag.Data = allSalesPerson;

            return View();
        }

    }
}
