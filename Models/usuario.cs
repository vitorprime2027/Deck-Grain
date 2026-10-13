using System;
namespace DeckGrain.Models
{
public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Senha { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        public string Status { get; set; } = string.Empty;
    }
}
//esse comentario vai salvar a humanidade