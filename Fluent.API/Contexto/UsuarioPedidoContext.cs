using Fluent.API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Fluent.API.Contexto
{
    public class UsuarioPedidoContext : DbContext
    {
        public UsuarioPedidoContext() : base("Server=localhost,1433;Database=FluentAPI;User ID=app;Password=123@123@; TrustServerCertificate=True") { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(c => c.Id);
            modelBuilder.Entity<Usuario>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Usuario>().Property(c => c.Nome).HasMaxLength(80);
            modelBuilder.Entity<Usuario>().Property(c => c.Endereco).HasMaxLength(100);
            modelBuilder.Entity<Usuario>().Property(c => c.Telefone).HasMaxLength(20);

            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<Pedido>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Pedido>().Property(p => p.Item).HasMaxLength(50);
            modelBuilder.Entity<Pedido>().HasRequired(c => c.Usuario).WithMany(p => p.Pedidos).HasForeignKey(p => p.idUsuario);

            modelBuilder.Entity<Pedido>().HasRequired(c => c.Usuario).WithMany(p => p.Pedidos).HasForeignKey(p => p.idUsuario).WillCascadeOnDelete(true); base.OnModelCreating(modelBuilder);
        }
    }
}
