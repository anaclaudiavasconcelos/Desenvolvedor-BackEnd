
namespace Pedido.Classes.Entidades
{
    //Objeto que pode existir de forma independente
    internal class Funcionario
    {
        //1º - Campo
        private string nome;

       
        //2º - Propriedades

        protected string Nome
        {
            get { return nome; } //leitura
            set { nome = value; } //grava
        }

        //3º - Construtor

        public Funcionario(string nome)
        {
            Nome = nome;
        }

    }
}
