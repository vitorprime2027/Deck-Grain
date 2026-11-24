using DeckGrain.Data;
using Microsoft.AspNetCore.Mvc;
using DeckGrain.Data;
namespace DeckGrain.Controllers
{
    public class EtiquetasController : Controller
    {
        private readonly AppDbContext _context;
        public EtiquetasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var lista = _context.Etiquetas.ToList();
            return View(lista);
        }
    }
}