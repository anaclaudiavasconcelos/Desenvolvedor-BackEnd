
using CasasBahia.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CasasBahia.Classes.Contextos
{
    internal class ProdutoContexto : DbContext
    {
        //Propriedade
        public DbSet<Produto> Produtos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder OpcaoDeConstrucao)
        {
            string config = @"Server=ECFP507D1319371\SQLEXPRESS03;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True";
            OpcaoDeConstrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Produto>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
            entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDeProduto);
            entidade.Property(e => e.ValorDoProduto);
            });


        }
    }
}
