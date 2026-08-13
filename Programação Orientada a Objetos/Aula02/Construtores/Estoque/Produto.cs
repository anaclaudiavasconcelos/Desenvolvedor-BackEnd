

namespace Estoque
{
    internal class Produto
    {
        //Campos ou atributos sempre com letra minúscula. Deixa os campos privados.
        string nome;
        int quantidade;
        double preco;
        //Construtor
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        //Construtor
        public Produto(string nome, int quantidade, double preco) //do tipo Produto - nome, quantidade, preco são paramentos
        {
            this.nome = nome; //1º nome é campo, segundo parametro.
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            quantidade += qtd;
        }

        public void RemoverProduto(int qtd)
        {
            quantidade -= qtd;
        }
        public double ValorTotal()
        {
            return preco * quantidade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, Quantidade: {quantidade}, Preço: {preco:c}, Total: {ValorTotal():c}");
        }
    }
}
