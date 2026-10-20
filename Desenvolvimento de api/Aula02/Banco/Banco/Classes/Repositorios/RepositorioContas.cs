using Banco.Classes.Models.Contextos;
using Banco.Classes.Models.Entidades;

namespace Banco.Classes.Repositorios
{
	public class RepositorioContas
	{
		private ContextoConta contexto = new ContextoConta();

		//Propriedades
		public ContextoConta Contexto
		{
			get { return contexto; }
			set { contexto = value; }
		}

		//Métodos
		public List<ContaBancaria> ListarContas()
		{
			var lista = contexto.contas.ToList();
			return lista;
		}

		public void CriarConta(ContaBancaria conta)
		{
			contexto.contas.Add(conta);
			contexto.SaveChanges();
		}

		public ContaBancaria PesquisarContasID(int numero)
		{
			var pesquisar = contexto.contas.FirstOrDefault(c => c.NumeroConta == numero);
			return pesquisar;
		}

		public bool EditarConta(ContaBancaria conta)
		{
			var existe = PesquisarContasID(conta.NumeroConta);
			if (existe == null)
			{
				return false;
			}
			existe.TitularConta = conta.TitularConta;
			contexto.SaveChanges();
			return true;
		}

		public bool DeletarConta(int numero)
		{
			var conta = PesquisarContasID(numero);
            if (conta == null)
            {
				return false;
            }
			else
			{
                contexto.Remove(conta);
                contexto.SaveChanges();
                return true;
            }
            
        }
	}
}
