using DeckGrain.Data;
using DeckGrain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DeckGrain.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly AppDbContext _context;

        public ComentariosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.Comentarios
                .Include(c => c.Post)
                .Include(c => c.Perfil)
                .ToListAsync();

            return View(lista);
        }

        public IActionResult Create()
        {
            ViewBag.Posts = new SelectList(_context.Posts, "PostId", "Titulo");
            ViewBag.Perfis = new SelectList(_context.Perfis, "PerfilId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Posts = new SelectList(_context.Posts, "PostId", "Titulo", comentario.PostId);
            ViewBag.Perfis = new SelectList(_context.Perfis, "PerfilId", "Nome", comentario.PerfilId);
            return View(comentario);
        }
    }
}
