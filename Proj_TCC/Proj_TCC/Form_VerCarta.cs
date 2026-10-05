using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proj_TCC
{
    public partial class Form_VerCarta : Form
    {
        public Form_VerCarta()
        {
            InitializeComponent();
        }

        public void DefinirCarta(int id)
        {
            string connectionString = "Server=127.0.0.1;Database=tcc;Uid=root;Pwd=;";
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                string query = "SELECT nome, texto, nome_arte, atributos_secundarios FROM carta WHERE id = @id";
                using (var command = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label_Nome.Text = reader.GetString("nome");
                            label_Tipos.Text = reader.GetString("atributos_secundarios");
                            label_Texto.Text = reader.GetString("texto");
                            string imagePath = "Imagens/ArtesdeCartas/" + reader.GetString("nome_arte") + ".jpeg";
                            pictureBox_Imagem.Image = Image.FromFile(imagePath);
                        }
                    }
                }
            }
        }
    }
}
