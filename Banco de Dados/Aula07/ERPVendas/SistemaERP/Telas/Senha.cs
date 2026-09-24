using SistemaERP.Classes.Services;
using System;
using System.Collections.Generic;


namespace SistemaERP.Telas
{
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void Senha_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Botão de fechar da tela
            TelaLogin.AbrirTela();
        }
    }
}
