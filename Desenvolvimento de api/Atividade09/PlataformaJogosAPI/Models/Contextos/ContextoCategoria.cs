using Microsoft.EntityFrameworkCore;
using PlataformaJogosAPI.Models.Entidades;

namespace PlataformaJogosAPI.Models.Contextos
{
    public class ContextoCategoria : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = Environment.GetEnvironmentVariable("db1");
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Categoria>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.Descricao);


            }

        );
        }

    }
}
