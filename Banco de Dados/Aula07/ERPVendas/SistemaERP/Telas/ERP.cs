using SistemaERP.Classes.Services;
using System;
using System.Collections.Generic;


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
    }
}
