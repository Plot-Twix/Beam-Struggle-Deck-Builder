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
            get { return groupBox_Decks.Text; }
            set { groupBox_Decks.Text = value; }
        }

        private void groupBox_Decks_Enter(object sender, EventArgs e)
        {

        }
    }
}
