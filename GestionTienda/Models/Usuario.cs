using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace GestionTienda.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [EmailAddress(ErrorMessage = "Por favor ingrese un email correcto")]
        public string Email { set; get; }
        [Display(Name="Direccion del usuario")]
        public string Direccion { set; get; }
        [NotMapped]
        public string Edad { set; get; }
        [ForeignKey("DetalleUsuario")]
        public int? DetalleUsuario_Id { set; get; }
        public DetalleUsuario DetalleUsuario { get; set; }
        
    }
}
