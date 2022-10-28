using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace GestionTienda.Models
{
    public class Categoria
    {
        [Key]
        public int Categoria_Id { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText ="[NULL]")]
        public string Nombre{ get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? Activo { get; set; }
        public List<Articulo> Articulo { get; set; } = new List<Articulo>();
    }
}
