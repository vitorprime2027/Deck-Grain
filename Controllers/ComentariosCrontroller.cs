using DeckGrain.Data;
using Microsoft.AspNetCore.Mvc;
namespace DeckGrain.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly AppDbContext _context;
        public ComentariosController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var lista = _context.Comentarios.ToList();
            return View(lista);
        }
    }
}