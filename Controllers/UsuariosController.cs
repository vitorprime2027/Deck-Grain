using DeckGrain.Data;
using Microsoft.AspNetCore.Mvc;
namespace DeckGrain.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var lista = _context.Usuarios.ToList();
            return View(lista);
        }
    }
}