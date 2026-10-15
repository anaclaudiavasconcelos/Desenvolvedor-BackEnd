using Microsoft.EntityFrameworkCore;
using APIPessoas.Models.Entidades;

namespace APIPessoas.Models.Contextos
{
    public class ProdutosContexto : DbContext
    {
        public DbSet<Produtos> produtos { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = "";
            opcoesDeConstrucao.UseSqlite(caminho);
        }

    }
}
