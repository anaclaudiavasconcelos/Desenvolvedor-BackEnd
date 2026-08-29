

using ZAbstracao.Enumeracao;
using ZAbstracao.Interfaces;

namespace ZAbstracao.Classes.Entidades
{
    abstract internal class Pessoa : IAssinatura
    {
        //Campo
        Contribuinte contribuinte;
               
        private string nome;
        private double renda;

        
        //Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected double RendaAnual
        {
            get { return renda; }
            set { renda = value; }
        }

        
        //Construtor
        protected Pessoa(string nome, double rendaAnual, Contribuinte contribuinte)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            this.contribuinte = contribuinte;

        }

       
        //Método

        public abstract void CalPessoaFisica();


        public abstract void CalPessoaJuridica();
        
    }
}
