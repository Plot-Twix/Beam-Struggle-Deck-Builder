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
            groupBox_Baralhos = new GroupBox();
            dataGridView_Baralhos = new DataGridView();
            groupBox_Baralhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Baralhos).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Baralhos
            // 
            groupBox_Baralhos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Baralhos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox_Baralhos.Controls.Add(dataGridView_Baralhos);
            groupBox_Baralhos.Location = new Point(3, 3);
            groupBox_Baralhos.Name = "groupBox_Baralhos";
            groupBox_Baralhos.Size = new Size(635, 175);
            groupBox_Baralhos.TabIndex = 0;
            groupBox_Baralhos.TabStop = false;
            groupBox_Baralhos.Text = "groupBox1";
            groupBox_Baralhos.Enter += groupBox_Decks_Enter;
            // 
            // dataGridView_Baralhos
            // 
            dataGridView_Baralhos.AllowUserToAddRows = false;
            dataGridView_Baralhos.AllowUserToDeleteRows = false;
            dataGridView_Baralhos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Baralhos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Baralhos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Baralhos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Baralhos.Location = new Point(6, 22);
            dataGridView_Baralhos.Name = "dataGridView_Baralhos";
            dataGridView_Baralhos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Baralhos.Size = new Size(623, 147);
            dataGridView_Baralhos.TabIndex = 0;
            dataGridView_Baralhos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Lista_de_Decks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox_Baralhos);
            Name = "Lista_de_Decks";
            Size = new Size(641, 181);
            groupBox_Baralhos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Baralhos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Baralhos;
        private DataGridView dataGridView_Baralhos;
    }
}
