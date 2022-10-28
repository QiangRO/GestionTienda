using GestionTienda.Datos;
using GestionTienda.Models;
using GestionTienda.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GestionTienda.Controllers
{
    public class EtiquetasController : Controller
    {
        public readonly ApplicationDbContext _contexto;
        public EtiquetasController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        [HttpGet]
        
        public ActionResult Index()
        {
            List<Etiqueta>listaEtiquetas = _contexto.Etiqueta.ToList();
            return View(listaEtiquetas);
        }

        // GET: EtiquetasController/Create
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }
        // POST: EtiquetasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Etiqueta etiqueta)
        {
            if(ModelState.IsValid)
            {
                _contexto.Etiqueta.Add(etiqueta);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: EtiquetasController/Edit/5
        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if(id==null)
            {
                return View();
            }
            var etiqueta = _contexto.Etiqueta.FirstOrDefault(c=> c.Etiqueta_Id==id);
            return View(etiqueta);
        }

        // POST: EtiquetasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Etiqueta etiqueta)
        {
            if(ModelState.IsValid)
            {
                _contexto.Etiqueta.Update(etiqueta);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(etiqueta);
        }

        // GET: EtiquetasController/Delete/5
        [HttpGet]
        public ActionResult Borrar(int? id)
        {
            var etiqueta = _contexto.Etiqueta.FirstOrDefault(c => c.Etiqueta_Id == id);
            _contexto.Etiqueta.Remove(etiqueta);
            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
