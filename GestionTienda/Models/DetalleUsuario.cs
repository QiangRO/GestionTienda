using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace GestionTienda.Models
{
    public class DetalleUsuario
    {
        [Key]
        public int DetalleUsuario_Id { get; set; }
        [Required]
        public string Cedula { get; set; }
        public string Deporte { get; set; }
        public string Mascota { get; set; }
        public Usuario Usuario { get; set; }
    }
}
