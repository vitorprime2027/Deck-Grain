using Microsoft.EntityFrameworkCore;
using DeckGrain.Models;

namespace DeckGrain.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
    }
}
