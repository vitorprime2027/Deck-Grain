using System;

namespace DeckGrain.Models
{
    public class Notificacao
    {
        public int Id { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Lido { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public int PerfilId { get; set; }
        public Perfil? Perfil { get; set; }
    }
}
