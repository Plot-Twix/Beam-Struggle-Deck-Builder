using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proj_TCC
{
    public partial class Form_CriarDeck : Form
    {
        private readonly string connectionString =
            "Server=127.0.0.1;Database=tcc;Uid=root;Pwd=;";

        public Form_CriarDeck()
        {
            InitializeComponent();
        }

        private void Form_CriarDeck_Load(object sender, EventArgs e)
        {
            atualizarBusca();
        }

        private void atualizarBusca()
        {
            string busca = textBox_Busca.Text.Trim();
            string query = "SELECT id, nome, nome_arte FROM carta WHERE nome LIKE @busca ORDER BY nome";

            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                using (var command = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@busca", "%" + busca + "%");
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        dataGridView_Cartas.Rows.Clear();
                        while (reader.Read())
                        {
                            string imagePath = "Imagens/ArtesdeCartas/" + reader.GetString("nome_arte") + ".jpeg";

                            dataGridView_Cartas.RowCount++;
                            int rowIndex = dataGridView_Cartas.RowCount - 1;

                            dataGridView_Cartas.Rows[rowIndex].Cells[2].Value = reader.GetString("nome");
                            dataGridView_Cartas.Rows[rowIndex].Cells[0].Value = reader.GetInt32("id");

                            var imageCell = dataGridView_Cartas.Rows[rowIndex].Cells[1] as DataGridViewImageCell;
                            imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            dataGridView_Cartas.Rows[rowIndex].Cells[1].Value = Image.FromFile(imagePath);
                        }
                    }
                }
            }
        }

        private void textBox_Busca_TextChanged(object sender, EventArgs e)
        {
            atualizarBusca();
        }

        private void dataGridView_Cartas_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView_Cartas.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(dataGridView_Cartas.CurrentRow.Cells[0].Value);

            var VerCarta = new Form_VerCarta();
            VerCarta.DefinirCarta(id);
            VerCarta.Show();
        }
    }
}
