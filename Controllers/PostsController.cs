using DeckGrain.Data;
using DeckGrain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DeckGrain.Controllers
{
    public class PostsController : Controller
    {
        private readonly AppDbContext _context;

        public PostsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.Posts
                .Include(p => p.Perfil)
                .Include(p => p.Etiquetas)
                .Include(p => p.Comentarios)
                .ToListAsync();

            return View(lista);
        }

        public IActionResult Create()
        {
            ViewBag.Perfis = new SelectList(_context.Perfis, "PerfilId", "Nome");
            ViewBag.Etiquetas = _context.Etiquetas.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post post, int[] etiquetasSelecionadas)
        {
            if (ModelState.IsValid)
            {
                if (etiquetasSelecionadas != null && etiquetasSelecionadas.Length > 0)
                {
                    var etiquetas = await _context.Etiquetas
                        .Where(e => etiquetasSelecionadas.Contains(e.Id))
                        .ToListAsync();

                    foreach (var etiqueta in etiquetas)
                    {
                        post.Etiquetas.Add(etiqueta);
                    }
                }

                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Perfis = new SelectList(_context.Perfis, "PerfilId", "Nome", post.PerfilId);
            ViewBag.Etiquetas = _context.Etiquetas.ToList();
            return View(post);
        }
    }
}
