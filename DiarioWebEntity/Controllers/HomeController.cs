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
            ViewBag.listaCategorias = handler.GetAllCategorias();
            ViewBag.listaAutores = handler.GetAllAutors();
            ViewBag.autores = autores;


            return View();
        }

        public  ActionResult ViewPublication(int id) {
            Publicacion publication = handler.GetPublicacionById(id);
            Dictionary<int, List<string>> commentsDic = handler.GetCommentsDictionary();
            ViewBag.publication = publication;
            ViewBag.Autor = handler.GetAutorById(publication.AutorFK).NombreCompleto;
            ViewBag.categoria = handler.GetCategoriesDictionary()[publication.CategoriaFK];
            List<string> comments = new List<string>();
            if (commentsDic.ContainsKey(publication.Id)) {
                comments = commentsDic[publication.Id];
            }
            ViewBag.comments = comments;
            return View();
        }

        public ActionResult AgregarComentario(int id) {

            ViewBag.publication = handler.GetPublicacionById(id);

            return View();
        }

        [Authorize]
        public ActionResult Administrador() {
            List<Publicacion> publicaciones = handler.GetAllPublications();
            Dictionary<int, int> comentariosCount = handler.GetCommentsCountDictionary();
            Dictionary<int, string> categorias = handler.GetCategoriesDictionary();
            Dictionary<int, string> autores = handler.GetAutorsDictionary();
            ViewBag.publicaciones = publicaciones;
            ViewBag.pubSize = publicaciones.Count();

            int count = comentariosCount[publicaciones[0].Id];

            ViewBag.comentarios = comentariosCount;
            ViewBag.categorias = categorias;
            ViewBag.listaCategorias = handler.GetAllCategorias();
            ViewBag.listaAutores = handler.GetAllAutors();
            ViewBag.autores = autores;
            return View();
        }

        public JsonResult GetComments(int idPub) {
            List<Comentario> comments = handler.GetCommentByPubId(idPub);
            return Json(comments, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddComment(Comentario comment) {
            ActionResult view = RedirectToAction("Index", "Home");
            int pubId = int.Parse(Request.Form["pubId"]);
            bool success = false;
            try {
                success = handler.CreateComment(comment.Texto, pubId);
            } catch(Exception e) {
                return view;
            }
            return view;
        }

        [HttpPost]
        public ActionResult AddPublication(Publicacion pub) {
            ActionResult view = RedirectToAction("Index", "Home");
            bool success = false;
            try {
                success = handler.CreatePublication(pub);
            } catch (Exception e) {
                return view;
            }
            return view;
        }

        public ActionResult AgregarPublicacion() {
            return View();
        }


        public ActionResult ViewAutor(int id) {
            Autor autor = handler.GetAutorById(id);
            List<Publicacion> publicaciones = handler.GetPublicacionesFromAutor(id);
            ViewBag.Autor = autor;
            ViewBag.publicaciones = publicaciones;
            return View();

        }

        public ActionResult ViewCategoria(int id) {
            Categoria categoria = handler.GetCategoriaById(id);
            List<Publicacion> publicaciones = handler.GetPublicacionesFromCategoria(id);
            ViewBag.Categoria = categoria;
            ViewBag.publicaciones = publicaciones;
            return View();

        }

    }
}