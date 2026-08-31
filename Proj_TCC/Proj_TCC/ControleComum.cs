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

        private void AbrirForm(Form form)
        {
            if (LoginHandler.GetLoginStatus() == 0)
            {
                form.ShowDialog();
            }
        }

        private void conferirInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form_VerUsuario());
        }
    }
}
