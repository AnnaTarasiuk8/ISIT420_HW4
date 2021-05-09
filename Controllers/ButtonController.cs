using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Controllers
{
    public class ButtonController : Controller
    {
        //List<ButtonModel>
        // GET: Button
        public ActionResult Index()
        {
            return View();
        }
    }
}