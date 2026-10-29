using Microsoft.AspNetCore.Mvc;
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
            var lista = _context.Perfis.ToList();
            return View(lista);
        }
    }
}