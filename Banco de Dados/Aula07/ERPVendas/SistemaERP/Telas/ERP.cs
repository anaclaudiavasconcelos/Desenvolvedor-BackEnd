using SistemaERP.Classes.Services;
using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;


namespace SistemaERP.Telas
{
    public partial class ERP : Form
    {
        public ERP()
        {
            InitializeComponent();
        }

        private void ERP_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Botão de Fechar
            TelaLogin.AbrirTela();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            TelaLogin.AbrirTela();
        }

        private void aprovaçãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Aprovacao tela = new Aprovacao();
            tela.Show();
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarRelatorio();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível carregar o relatório: Erro -> {ex.Message}");
            }
        }

        private void CarregarRelatorio()
        {
            Hide();
            RelatorioVendas relatorio = new RelatorioVendas();
            relatorio.Show();
        }
    }
}
