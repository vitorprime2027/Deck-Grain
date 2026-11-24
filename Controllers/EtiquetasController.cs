using DeckGrain.Data;
using DeckGrain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeckGrain.Controllers
{
    public class EtiquetasController : Controller
    {
        private readonly AppDbContext _context;

        public EtiquetasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.Etiquetas
                .Include(e => e.Posts)
                .ToListAsync();

            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Etiqueta etiqueta)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrWhiteSpace(etiqueta.Cor))
                {
                    etiqueta.Cor = "#0d6efd";
                }

                _context.Add(etiqueta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(etiqueta);
        }
    }
}
