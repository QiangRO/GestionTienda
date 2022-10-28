using GestionTienda.Datos;
using GestionTienda.Models;
using GestionTienda.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GestionTienda.Controllers
{
    public class UsuariosController : Controller
    {
        public readonly ApplicationDbContext _context;
        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] 
        // GET: UsuariosController
        public ActionResult Index()
        {
            List<Usuario> listaUsuarios = _context.Usuario.ToList();
            return View(listaUsuarios);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if(id == null)
            {
                return View();
            }
            var usuario = _context.Usuario.FirstOrDefault(c => c.Id == id);
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuario.Update(usuario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
        [HttpGet]
        public IActionResult Borrar(int? id)
        {
            var usuario = _context.Usuario.FirstOrDefault(c => c.Id == id);
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Detalle(int? id)
        {
            if(id==null)
            {
                return View();
            }
            var usuario = _context.Usuario.Include(d => d.DetalleUsuario).FirstOrDefault(u => u.Id == id);
            if (usuario==null)
            {
                return NotFound();
            }
            return View(usuario);
        }
        [HttpPost]
        public IActionResult AgregarDetalle(Usuario usuario)
        {
            if(usuario.DetalleUsuario.DetalleUsuario_Id == 0)
            {
                _context.DetalleUsuario.Add(usuario.DetalleUsuario);
                _context.SaveChanges();
                var usuarioDB = _context.Usuario.FirstOrDefault(u => u.Id == usuario.Id);
                usuarioDB.DetalleUsuario_Id = usuario.DetalleUsuario.DetalleUsuario_Id;
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
