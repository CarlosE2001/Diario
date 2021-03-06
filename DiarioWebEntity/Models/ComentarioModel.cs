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
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public Publicacion Publicacion { get; set; }
        [ForeignKey("Publicacion")]
        public int IdPublicacionPKFK { get; set; }
        public string Texto { get; set; }
    }
}