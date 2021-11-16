using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiarioWebEntity.Models;

namespace DiarioWebEntity.Controllers {

    

    public class HomeController : Controller {

        private ApplicationDbContext context;
        public HomeController() {
            context = new ApplicationDbContext();
        }

        public ActionResult Index() {
            List<Publicacion> publicaciones = context.Publicacion.ToList();
            ViewBag.publicaciones = publicaciones;
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}