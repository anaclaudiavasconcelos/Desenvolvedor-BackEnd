using Microsoft.EntityFrameworkCore;
using VendasSenai.Classes.Entidades;

namespace VendasSenai.Classes.Contextos
{
    internal class VendasContexto : DbContext
    {
        //Propriedade
        public DbSet<Vendas1> vendas { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319371\SQLEXPRESS03;Database=CamisasSENAI;Trusted_Connection=True;TrustServerCertificate=True;";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeContrucao)
        {
            modeloDeContrucao.Entity<Vendas1>(entidades =>
            {
                entidades.HasKey(e => e.Id);
                entidades.Property(e => e.DataCompra);
                entidades.Property(e => e.Tipo);
                entidades.Property(e => e.Marca);
                entidades.Property(e => e.Faturamento);
                entidades.Property(e => e.Lucro);
            });

        }
    }
}
