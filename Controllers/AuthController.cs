using Microsoft.AspNetCore.Mvc;

namespace DeckGrain.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login() => View();
        public IActionResult Cadastro() => View();
    }
}
