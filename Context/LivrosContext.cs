using Microsoft.EntityFrameworkCore;
using ProjetoLivros.Models;

namespace ProjetoLivros.Context
{
    public class LivrosContext : DbContext
    {
        //cada Tabela -> DbSet 
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Assinatura> Assinatura { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria>Usuarios { get; set; }

        //Ctor
        public LivrosContext(DbContextOptions<LivrosContext> options) : base(options) 
        {

        }

        //Metodo de sobrescrever 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //String de conexao 
            optionsBuilder.UseSqlServer("Data Source=NOTE12-S28\\SQLEXPRESS;Initial Catalog=Livros;User Id=sa;Password=Senai@134;TrustServerCertificate=true;");

        }
         // Define os "tipos" do banco de dados, limites de cacteres
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(
                //Representacao da tabela 
                entity =>
                {
                    //Primary Key

                    // Email e UNICO
                    entity.Property(u => u.Email).IsRequired().HasMaxLength(150).IsUnicode(false);
                    entity.HasIndex(u => u.Email).IsUnique();
                    //Cont.
                    entity.HasKey(u=> u.UsuarioId);
                    entity.Property(u => u.NomeCompleto).IsRequired().HasMaxLength(150).IsUnicode(false); 
                    entity.Property(u => u.Senha).IsRequired().HasMaxLength(255).IsUnicode(false);
                    entity.Property(u => u.Telefone).IsRequired().HasMaxLength(15).IsUnicode(false);
                    entity.Property(u => u.DataCadastro).IsRequired();
                    entity.Property(u => u.DataAtualizacao).IsRequired();

                    //Este código estabelece um relacionamento com deleção em cascata entre Usuario e TipoUsuario.
                    entity.HasOne(u => u.TipoUsuario).WithMany(t => t.Usuarios).HasForeignKey(u => u.TipoUsuarioId).OnDelete(DeleteBehavior.Cascade);
                }


            );
        }
    }
}
//DbSet= Para criar uma tabela no Banco de Dados