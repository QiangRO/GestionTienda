using GestionTienda.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestionTienda.ViewModels
{
    public class ArticuloEtiquetaVM
    {
        public ArticuloEtiqueta ArticuloEtiqueta { get; set; }
        public Articulo Articulo { get; set; }
        public IEnumerable<ArticuloEtiqueta> listaArticuloEtiquetas { get; set; }
        public IEnumerable<SelectListItem> listaEtiquetas { get; set; }
    }
}
