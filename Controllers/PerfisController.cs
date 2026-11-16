using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeckGrain.Data;
namespace DeckGrain.Controllers
{
    public class PerfisController : Controller
    {
        private readonly AppDbContext _context;
        public PerfisController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var lista = _context.Perfis.Include(p => p.Usuario).ToList();
            return View(lista);
        }
    }
}