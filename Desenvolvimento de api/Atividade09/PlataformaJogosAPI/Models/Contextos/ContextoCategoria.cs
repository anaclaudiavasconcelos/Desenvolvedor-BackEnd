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
            string caminho = "Server = ECFP507D1319371\\SQLEXPRESS03; Database = PlataformaJogos; Trusted_Connection = True; TrustServerCertificate = True;";
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
