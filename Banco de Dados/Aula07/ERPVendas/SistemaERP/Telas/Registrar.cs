

using SistemaERP.Classes.Services;

namespace SistemaERP.Telas
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Botão de Fechar
            TelaLogin.AbrirTela();
        }
    }
}
