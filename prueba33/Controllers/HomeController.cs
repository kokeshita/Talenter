using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace prueba33.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            User user = new User();
            
            ViewBag.Title = "Index - Talenter";


            return View();
        }



        public ActionResult Register()
      
        {

            ViewBag.Title = "Registro - Talenter";
            return View();
        }

     

        public ActionResult UserMatch()
        {
            ViewBag.Title = "Aplicar Talento - Talenter";
            return View();
        }



        public ActionResult AccountInfo()
        {
            ViewBag.Title = "Configuracion de cuenta - Talenter";
            return View();
        }
    }
}
