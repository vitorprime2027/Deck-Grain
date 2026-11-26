namespace DeckGrain.Models
{
    public class Perfil
    {
        public int PerfilId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Biografia { get; set; } = string.Empty;
        public string LinguagemPreferida { get; set; } = string.Empty;
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public ICollection<Notificacao> Notificacoes { get; set; } = new List<Notificacao>();
    }
}
