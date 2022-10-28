using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using GestionTienda.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestionTienda.ViewModels
{
    public class ArticuloCategoria
    {
        public Articulo Articulo { get; set; }
        public IEnumerable<SelectListItem> ListaCategorias { get; set; }
    }
}
