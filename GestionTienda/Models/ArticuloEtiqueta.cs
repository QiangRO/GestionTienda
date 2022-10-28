using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace GestionTienda.Models
{
    public class ArticuloEtiqueta
    {
        [ForeignKey("Articulo")]
        public int Articulo_Id { get; set; }
        [ForeignKey("Etiqueta")]
        public int Etiqueta_Id { get; set; }
        public Articulo Articulo { get; set; }
        public Etiqueta Etiqueta { get; set; }
    }
}
