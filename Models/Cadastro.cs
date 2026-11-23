using System.ComponentModel.DataAnnotations;

namespace DeckGrain.Models
{
    public class Cadastro
    {
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [MinLength(8, ErrorMessage = "A senha deve ter pelo menos 8 caracteres.")]
        public string Senha { get; set; } = string.Empty;
    }
}
