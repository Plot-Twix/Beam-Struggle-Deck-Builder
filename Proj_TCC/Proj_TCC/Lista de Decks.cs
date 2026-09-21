using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proj_TCC
{
    public partial class Lista_de_Decks : UserControl
    {
        private readonly string connectionString =
            "Server=127.0.0.1;Database=tcc;Uid=root;Pwd=;";

        public Lista_de_Decks()
        {
            InitializeComponent();
        }

        public void Lista_de_Decks_Load(object sender, EventArgs e)
        {
            // This method is called when the user control is loaded.
            // You can add any initialization code here if needed.
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string GroupBoxText
        {
            get { return groupBox_Baralhos.Text; }
            set { groupBox_Baralhos.Text = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public BindingList<Baralho> Baralhos
        {
            get { return (BindingList<Baralho>)dataGridView_Baralhos.DataSource; }
            set { dataGridView_Baralhos.DataSource = value; }
        }
        private void groupBox_Decks_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
