namespace DeckGrain.Models
{
    public class Configuracao
    {
        public int Id { get; set; }
        public bool ModoNoturno { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
