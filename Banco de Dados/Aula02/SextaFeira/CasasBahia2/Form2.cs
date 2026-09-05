using CasasBahia2.Classes.Contextos;

using CasasBahia2.Classes.Entidades;


namespace CasasBahia2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }
        //Tab 1 - Botão para cadastrar item
        private void button4_Click(object sender, EventArgs e)
        {
            ProdutosContexto contexto = new ProdutosContexto();
            string cadastroNomeProduto = textBox17.Text;
            int quantidadeDeProduto = int.Parse(textBox18.Text);
            decimal valorDoProduto = decimal.Parse(textBox9.Text);

            Produtos produtos = new Produtos(cadastroNomeProduto, quantidadeDeProduto, valorDoProduto);
            contexto.Produtos.Add(produtos);
            contexto.SaveChanges();
            MessageBox.Show("Cadastrado realizado com sucesso!");
            textBox17.Text = "";
            textBox18.Text = "";
            textBox9.Text = "";
        }


        //Tab 2 - Botão para pesquisar item
        private void button5_Click(object sender, EventArgs e)
        {
            ProdutosContexto contexto = new ProdutosContexto();
            var produto = contexto.Produtos.FirstOrDefault(p => p.CodigoDoProduto == int.Parse(textBox15.Text));
            if(produto == null)
            {
                MessageBox.Show("Produto não cadastrado");
            }
            else
            {
                MessageBox.Show("- Produto encontrado -" +
                    $"Nome do produto: {produto.NomeDoProduto}" +
                $"Quantidade em estoque: {produto.QuantidadeDeProduto}" +
                    $"Preço do produto: {produto.ValorDoProduto:c}");
            }

            textBox15.Text = "";
        }
        //Tab 3 - Botão para editar / pesquisar item
        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
