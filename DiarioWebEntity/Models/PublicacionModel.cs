using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using DiarioWebEntity.Models;

namespace DiarioWebEntity.Models
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Titulo { get; set; }
        public string LinkImg { get; set; }
        public string Resumen { get; set; }

        public int AutorFK { get; set; }

        public int CategoriaFK { get; set; }
    }
}