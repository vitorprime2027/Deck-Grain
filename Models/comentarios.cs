namespace Comentarios.Models
{
    public class Comentario
    {
        public Date DataCriacao { get; set; }
        public Int PostId { get; set; }
        public Post Post{ get; set; }
        public Int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
