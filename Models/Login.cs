using System.ComponentModel.DataAnnotations;

namespace DeckGrain.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Informe seu e-mail ou nome de usuário.")]
        public string EmailOuUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe sua senha.")]
        public string Senha { get; set; } = string.Empty;

        public bool LembrarMe { get; set; }
    }
}
