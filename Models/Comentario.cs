using System;

namespace DeckGrain.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Conteudo { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
        public int PerfilId { get; set; }
        public virtual Perfil? Perfil { get; set; }
    }
}
