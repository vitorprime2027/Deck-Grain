using DeckGrain.Models.Comentario;
using DeckGrain.Models.Etiqueta;
using DeckGrain.Models.Usuario;

namespace DeckGrain.Models.Post;

public class post
{
    public string titulo { get; set; }
    public string descricao { get; set; }
    public int PostID { get; set; }
    public int QuantidadeCurtidas { get; set; }
    public string ID { get; set; }
}
