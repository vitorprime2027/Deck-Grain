namespace DeckGrain.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int QuantidadeCurtidas { get; set; }
        public int PerfilId { get; set; }
        public Perfil? Perfil { get; set; }
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public ICollection<Etiqueta> Etiquetas { get; set; } = new List<Etiqueta>();
    }
}
