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
    public partial class Meus_Decks : Form
    {
        private BindingList<Baralho> baralhos = new BindingList<Baralho>();
        private readonly string connectionString =
            "Server=127.0.0.1;Database=tcc;Uid=root;Pwd=;";

        public Meus_Decks()
        {
            InitializeComponent();
        }

        private void Meus_Decks_Load(object sender, EventArgs e)
        {
            string query = "SELECT nome, ultima_alteracao, favorito, delecao_bloqueada FROM baralho WHERE id_usuario = @idUsuario ORDER BY favorito DESC, ultima_alteracao DESC";
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsuario", LoginHandler.idUsuario);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView_MeusDecks.Rows.Add(
                                reader.GetString("nome"),
                                reader.GetBoolean("favorito"),
                                reader.GetBoolean("delecao_bloqueada")
                            );
                        }
                    }
                }
            }
        }

        private void button_NovoDeck_Click(object sender, EventArgs e)
        {
            new Form_CriarDeck().Show();
        }
    }
}
