using VendasSenai.Classes.Contextos;



namespace Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        void CarregarDados()
        {
            try
            {
                VendasContexto vendascontexto = new VendasContexto();
                var listaDeVenda = vendascontexto.vendas.ToList();
                dataGridView1.DataSource = listaDeVenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }


        }
    }
}
