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
            string query = "SELECT nome FROM carta WHERE nome LIKE @busca";

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
                            dataGridView_Cartas.RowCount++;
                            int rowIndex = dataGridView_Cartas.RowCount - 1;
                            dataGridView_Cartas.Rows[rowIndex].Cells[1].Value = reader.GetString("nome");
                        }
                    }
                }
            }
        }

        private void textBox_Busca_TextChanged(object sender, EventArgs e)
        {
            atualizarBusca();
        }
    }
}
