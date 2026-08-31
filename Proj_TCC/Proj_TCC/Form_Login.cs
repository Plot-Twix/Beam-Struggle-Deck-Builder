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

                MySqlDataReader reader;
                using (MySqlConnection conexao = new MySqlConnection("server=localhost;database=tcc;uid=root;pwd='';SSL Mode = disabled"))
                {
                    MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario WHERE email = '{email}' AND senha = '{senha}'", conexao);

                     reader = comando.ExecuteReader();
                }

                if (!reader.HasRows)
                {
                    
                    throw new Exception("Credenciais inválidas"); //Exceção quando as credenciais são inválidas
                }
                else
                {
                    reader.Read();
                    string localId = reader["id_usuario"].ToString();
                    string localEmail = reader["email"].ToString();
                    string localSenha = reader["senha"].ToString();

                    LoginHandler.CreateLogin(int.Parse(localId), localEmail, localSenha);
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
