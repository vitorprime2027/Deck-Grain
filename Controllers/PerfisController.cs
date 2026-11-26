using DeckGrain.Data;
using DeckGrain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DeckGrain.Controllers
{
    public class PerfisController : Controller
    {
        private readonly AppDbContext _context;

        public PerfisController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var lista = await _context.Perfis
                .Include(p => p.Usuario)
                .ToListAsync();

            return View(lista);
        }

        
        public IActionResult Create()
        {
            var usuariosSemPerfil = _context.Usuarios
                .Where(u => u.Perfil == null)
                .ToList();

            ViewBag.Usuarios = new SelectList(usuariosSemPerfil, "UsuarioId", "Email");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Perfil perfil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(perfil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var usuariosSemPerfil = _context.Usuarios
                .Where(u => u.Perfil == null)
                .ToList();

            ViewBag.Usuarios = new SelectList(usuariosSemPerfil, "UsuarioId", "Email", perfil.UsuarioId);
            return View(perfil);
        }
    }
}
