using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_TCC
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void label_Login_Click(object sender, EventArgs e)
        {

        }

        private void button_FazerLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string email = textBox_Email.Text.Trim();
                string senha = textBox_Senha.Text.Trim();

                LoginHandler.Login(email, senha, out int idUsuario, out string mensagem);
                LoginHandler.idUsuario = idUsuario;
                MessageBox.Show(mensagem);

                if (checkBox_Lembrar.Checked)
                {
                    //MessageBox.Show(idUsuario.ToString());
                    var sessaoService = new SessaoService();
                    sessaoService.CriarSessaoPersistente(idUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer login: " + ex.Message);
            }
        }

        private void linkLabel_CriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form_CriarConta().ShowDialog();
        }
    }
}
