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
    public class Categoria
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
    }
}