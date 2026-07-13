namespace Proj_TCC
{
    partial class Lista_de_Decks
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_Decks = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox_Decks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Decks
            // 
            groupBox_Decks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Decks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox_Decks.Controls.Add(dataGridView1);
            groupBox_Decks.Location = new Point(3, 3);
            groupBox_Decks.Name = "groupBox_Decks";
            groupBox_Decks.Size = new Size(635, 156);
            groupBox_Decks.TabIndex = 0;
            groupBox_Decks.TabStop = false;
            groupBox_Decks.Text = "groupBox1";
            groupBox_Decks.Enter += groupBox_Decks_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(623, 128);
            dataGridView1.TabIndex = 0;
            // 
            // Lista_de_Decks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox_Decks);
            Name = "Lista_de_Decks";
            Size = new Size(641, 181);
            groupBox_Decks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Decks;
        private DataGridView dataGridView1;
    }
}
