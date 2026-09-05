using CasasBahia2.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CasasBahia2.Classes.Contextos
{
    internal class LoginsContexto : DbContext
    {
        //Propriedades
        public DbSet<Logins> Logins { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319371\SQLEXPRESS03; Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Logins>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Usuario); 
                entidade.Property(e => e.Senha);
                entidade.Property(e => e.Regra);

            });

        }

    }
}
