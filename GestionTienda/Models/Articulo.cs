using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace GestionTienda.Models
{
    public class Articulo
    {
        [Key]
        public int Articulo_Id { get; set; }
        [Column("Titulo")]
        [Required(ErrorMessage = "El articulo es obligatorio")]
        [MaxLength(20)]
        public string TituloArticulo { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "La descripcion no debe superrar los 500 caracteres")]
        public string Descripcion { get; set; }
        [Range(1.0, 5.0)]
        public double Calificacion{ get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public Categoria Categoria { get; set; }
        [ForeignKey("Categoria")]
        public int Categoria_Id { get; set; }
        public ICollection<ArticuloEtiqueta> ArticuloEtiqueta { get; set; }

    }
}
