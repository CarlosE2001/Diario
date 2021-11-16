using DiarioWebEntity.Handlers;
using DiarioWebEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiarioWebEntity.Controllers {

    public class HomeController : Controller {
        DatabaseHandler handler = new DatabaseHandler();
        public ActionResult Index() {
            List<Publicacion> publicaciones = handler.GetAllPublications();
            Dictionary<int, int> comentariosCount = handler.GetCommentsCountDictionary();
            Dictionary<int, string> categorias = handler.GetCategoriesDictionary();
            Dictionary<int, string> autores = handler.GetAutorsDictionary();



            ViewBag.publicaciones = publicaciones;
            ViewBag.pubSize = publicaciones.Count();

            int count = comentariosCount[publicaciones[0].Id];

            ViewBag.comentarios = comentariosCount;
            ViewBag.categorias = categorias;
            ViewBag.autores = autores;


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