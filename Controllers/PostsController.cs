using DeckGrain.Data;
using Microsoft.AspNetCore.Mvc;
namespace DeckGrain.Controllers
{
    public class PostsController : Controller
    {
        private readonly AppDbContext _context;
        public PostsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var lista = _context.Posts.ToList();
            return View(lista);
        }
    }
}