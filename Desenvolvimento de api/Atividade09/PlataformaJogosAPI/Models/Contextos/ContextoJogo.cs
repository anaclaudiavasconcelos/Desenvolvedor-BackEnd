
using Microsoft.EntityFrameworkCore;
using PlataformaJogosAPI.Models.Entidades;

namespace PlataformaJogosAPI.Models.Contextos
{
    public class ContextoJogo : DbContext
    {

        //Propriedade
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estudio> Estudios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = Environment.GetEnvironmentVariable("db1");
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Jogo>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.Descricao);

                entidade.Property(e => e.Preco);

                entidade.Property(e => e.CategoriaId);

                entidade.Property(e => e.EstudioId);



            }

        );
        }





    }
}
