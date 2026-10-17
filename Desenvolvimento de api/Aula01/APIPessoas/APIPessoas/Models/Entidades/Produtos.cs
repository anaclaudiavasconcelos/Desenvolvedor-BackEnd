using System.ComponentModel.DataAnnotations;

namespace APIPessoas.Models.Entidades
{
    public class Produtos
    {

        //Propriedades
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Para cadastrar um produto, inserir um nome de um produto")]
        [Length(2,15, ErrorMessage = "Tamanho mínimo do nome 2 letras e máximo 15 letras")]
        public string Nome { get; set; }
        [Required]
        [Range(0,30000, ErrorMessage = "O preço deve ser um valor entre 0 e 30000")]
        public decimal Preco { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        [Range(0,100, ErrorMessage = "A quantidade deve ser um valor entre 0 e 100")]
        public int Quantidade { get; set; }

        //Construtor
        public Produtos(string nome, decimal preco, string descricao, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
        }

    }
}
