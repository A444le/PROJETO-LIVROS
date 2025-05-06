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
                    entity.HasKey(u=> u.UsuarioId);

                    //Ir campo a campo configurando
                    // Email e UNICO
                    entity.Property(u => u.Email).IsRequired().HasMaxLength(150).IsUnicode(false);
                    entity.HasIndex(u => u.Email).IsUnique();
                    //Cont.
                    entity.Property(u => u.NomeCompleto).IsRequired().HasMaxLength(150).IsUnicode(false); 
                    entity.Property(u => u.Senha).IsRequired().HasMaxLength(255).IsUnicode(false);
                    entity.Property(u => u.Telefone).IsRequired().HasMaxLength(15).IsUnicode(false);
                    entity.Property(u => u.DataCadastro).IsRequired();
                    entity.Property(u => u.DataAtualizacao).IsRequired();

                    //Este código estabelece um RELACIONAMENTO com deleção em cascata entre Usuario e TipoUsuario.
                    entity.HasOne(u => u.TipoUsuario).WithMany(t => t.Usuarios).HasForeignKey(u => u.TipoUsuarioId).OnDelete(DeleteBehavior.Cascade);
                }


            );
                //TipoUsuario
                modelBuilder.Entity<TipoUsuario>(entity =>
                {
                    //Primary Key
                    entity.HasKey(t => t.TipoUsuarioId);

                    entity.HasKey(t => t .TipoUsuarioId);
                    entity.Property(t =>t.DescricaoTipo).IsRequired().HasMaxLength(100).IsUnicode(false);
                });

                    modelBuilder.Entity<Livro>(entity =>
                    {
                        //Primary Key
                        entity.HasKey(l => l.LivrosId);
                        //Tabela 
                        entity.Property(l => l.Titulo).IsRequired().HasMaxLength(200).IsUnicode(false);
                        entity.Property(l =>l.Autor).IsRequired().HasMaxLength(200).IsUnicode(false);
                        entity.Property(l =>l.Descricao).HasMaxLength(255).IsUnicode(false);
                        entity.Property(l => l.DataPublicacao).IsRequired();
                        //RELACIONAMENTO
                        //Livro - Categoria 
                        //1 - N
                        entity.HasOne(l => l.Categoria).WithMany(c => c.Livros).HasForeignKey(l => l.CategoriaId).OnDelete(DeleteBehavior.Cascade);
                    });
                            modelBuilder.Entity<Categoria>(entity =>
                            {
                                //Primary Key
                                entity.HasKey(c => c.CategoriaId);
                                //Tabela 
                                entity.Property(l => l.NomeCategoria).IsRequired().HasMaxLength(150).IsUnicode(false);
               
                                //RELACIONAMENTO
                                //Livro - Categoria 
                                //1 - N
                                //entity.HasOne(l => l.Categoria).WithMany(c => c.Livros).HasForeignKey(l => l.CategoriaId).OnDelete(DeleteBehavior.Cascade);
                            });
                                modelBuilder.Entity<Assinatura>(entity =>
                                {
                                    //Primary Key
                                    entity.HasKey(a => a.AssinaturaId);
                                    //Tabela 
                                    entity.Property(a => a.DataInicio).IsRequired();
                                    entity.Property(a => a.DataFim).IsRequired();
                                    entity.Property(a => a.Status).IsRequired().HasMaxLength(20).IsUnicode(false);
                                   

                                    //RELACIONAMENTO
                                    //Livro - Categoria 
                                    //1 - N
                                    entity.HasOne(a => a.Usuario).WithMany().HasForeignKey(a => a.UsuarioId).OnDelete(DeleteBehavior.Cascade);
                                });
        }
    }
}
//DbSet= Para criar uma tabela no Banco de Dados

//WithMany = Tem muitos 
//HasMaxLength = Ter no maximo 
//IsRequired = E obrigatorio 
//Unicode = permite que uma propriedade de string em um modelo de dados suporte textos de diversos caracteres.