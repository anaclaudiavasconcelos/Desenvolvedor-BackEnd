using System.ComponentModel.DataAnnotations;

namespace PlataformaJogosAPI.Models.Entidades
{
    public class Usuario
    {

        //Propriedades
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        //Construtor    
        public Usuario(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

    }
}
