using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using MySql;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Proj_TCC
{
    [DefaultEvent(nameof(TextChanged))]
    public partial class ControleComum : UserControl
    {
        public ControleComum()
        {
            InitializeComponent();
        }

        private void label_Letreiro_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private Boolean CheckLogin()
        {
            // Lógica para verificar se o usuário está logado
            try
            {
                StreamReader stream = new StreamReader("login_info.txt");
                string text = stream.ReadToEnd(); //leitura das informações de login locais
                stream.Close();

                if (text.Contains("id_usuario: -1"))
                {
                    new Form_Login().ShowDialog();
                    return false;
                }

                //lógica para pegar o id do usuário logado e buscar suas informações no banco de dados
                int startIndex = text.IndexOf("id_usuario: ") + 12;
                int endIndex = text.IndexOf('\n', startIndex);
                MessageBox.Show(text.Substring(startIndex, endIndex - startIndex));
                //int id_usuario = int.Parse(text.Substring(startIndex, endIndex - startIndex));

                /*
                MySqlConnection conexao = new MySqlConnection(stringConexao);
                MySqlCommand comando = new MySqlCommand("SELECT * FROM usuario WHERE id_usuario = @id_usuario", conexao);
                */
            }
            catch (FileNotFoundException) {
                StreamWriter sw = new StreamWriter("login_info.txt");
                sw.Write("id_usuario: -1\n" +
                    "email: null\n" +
                    "senha: null");
                sw.Close();

                new Form_Login().ShowDialog();

                return false;
            }

            return true;
        }

        private void AbrirForm(Form form)
        {
            if(CheckLogin())
            {
                form.ShowDialog();
            }
        }

        private void conferirInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new Form_VerUsuario();
            AbrirForm(newForm);
        }
    }
}
