namespace DeckGrain.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int QuantidadeCurtidas { get; set; }
    }
}
