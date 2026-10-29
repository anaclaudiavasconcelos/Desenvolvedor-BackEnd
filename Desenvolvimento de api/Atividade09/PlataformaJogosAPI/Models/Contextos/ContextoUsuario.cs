using Microsoft.EntityFrameworkCore;
using PlataformaJogosAPI.Models.Entidades;

namespace PlataformaJogosAPI.Models.Contextos
{
    public class ContextoUsuario : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = Environment.GetEnvironmentVariable("db1");
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Usuario>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Email);

                entidade.Property(e => e.Senha);


            }

        );
        }



    }
}
