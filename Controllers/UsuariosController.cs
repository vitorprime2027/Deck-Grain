using DeckGrain.Data;
using DeckGrain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeckGrain.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var lista = await _context.Usuarios
                .Include(u => u.Perfil)
                .Include(u => u.Configuracao)
                .ToListAsync();

            return View(lista);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrWhiteSpace(usuario.Status))
                {
                    usuario.Status = "Ativo";
                }

                usuario.Configuracao = new Configuracao
                {
                    ModoNoturno = false
                };

                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(usuario);
        }
    }
}
