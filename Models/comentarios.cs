using DeckGrain.Models.Etiqueta;
using DeckGrain.Models.Post;
using DeckGrain.Models.Usuario;

namespace DeckGrain.Models.Comentario;

public class Comentario
{
    public usuario DataCriacao { get; set; }
    public post PostID { get; set; }
    public post Post { get; set; }
    public usuario UsuarioID { get; set; }
    public usuario Usuario { get; set; }
}
