
namespace Pedido.Classes.Entidades
{
    internal class Empresa
    {
		//1º - Campos
		private string nome;
		private List<Funcionario> funcionarios;

        

        protected  List<Funcionario> ListaFuncionarios		{
			get { return funcionarios; }
			set { funcionarios = value; }
		}


		//2º - Propriedades
		protected string NomeDaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}

		//3º - Construtor

        public Empresa(string nomeDaEmpresa)
        {
            NomeDaEmpresa = nomeDaEmpresa;
			ListaFuncionarios = new List<Funcionario>();
        }

		//4º - Métodos
		public void AdicionarFuncionario(Funcionario funcionario)
		{
			ListaFuncionarios.Add(funcionario);
		}
    }
}
