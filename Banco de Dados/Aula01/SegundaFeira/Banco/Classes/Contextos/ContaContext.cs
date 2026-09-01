using Banco.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Banco.Classes.Contextos
{
    internal class ContaContext : DbContext
    {
        //Propriedade - Representa as contas no BD
        public DbSet<Conta> contas { get; set; } //lista de contas pq vai criar várias contas

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string config = @"Server=ECFP507D1319371\SQLEXPRESS03;Database=BancoDBContas;Trusted_Connection=True;TrustServerCertificate=True;"; //@server para ignorar as barras que são operador de escape
            opcoesDeConstrucao.UseSqlServer(config); //vou usar sqlserver
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao) //mapear a classe
        {
            modeloDeConstrucao.Entity<Conta>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.NumeroDaConta);
                entidade.Property(e => e.TitularDaConta);
                entidade.Property(e => e.SaldoDaConta);

            });//mapear a classe
        }
    }
}
