using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace GestionTienda.Models
{
    public class Etiqueta
    {
        [Key]
        public int Etiqueta_Id { set; get; }
        public string Titulo { set; get; }
        [DataType(DataType.Date)]
        public DateTime Fecha { set; get; }
        public ICollection<ArticuloEtiqueta> ArticuloEtiqueta { set; get; }
    }
}
