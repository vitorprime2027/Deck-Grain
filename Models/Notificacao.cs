namespace DeckGrain.Models
{
    public class Notificacao
    {
        public int Id { get; set; }
        public string Mensagem { get; set; }
        public bool Lido { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
