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
        [Key]
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Titulo { get; set; }
        public string LinkImg { get; set; }
        public string Resumen { get; set; }

        public Autor Autor { get; set; }
        [ForeignKey("Autor")]
        public int AutorFK { get; set; }

        public Categoria Categoria { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaFK { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
    }
}