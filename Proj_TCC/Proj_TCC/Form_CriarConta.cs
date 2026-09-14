using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proj_TCC
{
    public partial class Form_CriarConta : Form
    {
        public Form_CriarConta()
        {
            InitializeComponent();
        }

        private void label_CriarConta_Click(object sender, EventArgs e)
        {

        }

        private void button_FazerLogin_Click(object sender, EventArgs e)
        {
            string apelido = textBox_Apelido.Text.Trim();
            string email = textBox_Email.Text.Trim();
            string senha = textBox_Senha.Text.Trim();

            if (string.IsNullOrEmpty(apelido) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            LoginHandler.CadastrarUsuario(apelido, email, senha, out string mensagem);
            MessageBox.Show(mensagem); 
            return;
        }
    }
}
