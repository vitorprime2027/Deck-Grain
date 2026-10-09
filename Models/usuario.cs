using DeckGrain.Models.Comentario;
using DeckGrain.Models.Etiqueta;
using DeckGrain.Models.Post;

namespace DeckGrain.Models.Usuario;

public class usuario
{
    public string Senha { get; set; }
    public string Email { get; set; }
    public DateTime DataCriacao { get; set; }
    public string Status { get; set; }
    public int UsuarioID { get; set; }
}
