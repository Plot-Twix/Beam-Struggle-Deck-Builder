namespace Proj_TCC
{
    partial class Form_CriarDeck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            controleComum1 = new ControleComum();
            groupBox_Baralho = new GroupBox();
            dataGridView_Baralho = new DataGridView();
            Imagem = new DataGridViewImageColumn();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            groupBox_Cartas = new GroupBox();
            label_NomeCarta = new Label();
            textBox_Busca = new TextBox();
            dataGridView_Cartas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            groupBox_Baralho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Baralho).BeginInit();
            groupBox_Cartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cartas).BeginInit();
            SuspendLayout();
            // 
            // controleComum1
            // 
            controleComum1.AutoSize = true;
            controleComum1.Location = new Point(0, 0);
            controleComum1.Name = "controleComum1";
            controleComum1.Size = new Size(816, 112);
            controleComum1.TabIndex = 0;
            // 
            // groupBox_Baralho
            // 
            groupBox_Baralho.Controls.Add(dataGridView_Baralho);
            groupBox_Baralho.Location = new Point(12, 118);
            groupBox_Baralho.Name = "groupBox_Baralho";
            groupBox_Baralho.Size = new Size(424, 442);
            groupBox_Baralho.TabIndex = 1;
            groupBox_Baralho.TabStop = false;
            groupBox_Baralho.Text = "Baralho";
            // 
            // dataGridView_Baralho
            // 
            dataGridView_Baralho.AllowUserToAddRows = false;
            dataGridView_Baralho.AllowUserToDeleteRows = false;
            dataGridView_Baralho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Baralho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Baralho.Columns.AddRange(new DataGridViewColumn[] { Imagem, Nome, Quantidade });
            dataGridView_Baralho.Dock = DockStyle.Fill;
            dataGridView_Baralho.Location = new Point(3, 19);
            dataGridView_Baralho.Name = "dataGridView_Baralho";
            dataGridView_Baralho.Size = new Size(418, 420);
            dataGridView_Baralho.TabIndex = 0;
            // 
            // Imagem
            // 
            Imagem.HeaderText = "Imagem";
            Imagem.Name = "Imagem";
            Imagem.ReadOnly = true;
            Imagem.Resizable = DataGridViewTriState.True;
            Imagem.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Qtd";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // groupBox_Cartas
            // 
            groupBox_Cartas.Controls.Add(label_NomeCarta);
            groupBox_Cartas.Controls.Add(textBox_Busca);
            groupBox_Cartas.Controls.Add(dataGridView_Cartas);
            groupBox_Cartas.Location = new Point(442, 118);
            groupBox_Cartas.Name = "groupBox_Cartas";
            groupBox_Cartas.Size = new Size(346, 442);
            groupBox_Cartas.TabIndex = 2;
            groupBox_Cartas.TabStop = false;
            groupBox_Cartas.Text = "Cartas";
            // 
            // label_NomeCarta
            // 
            label_NomeCarta.AutoSize = true;
            label_NomeCarta.Location = new Point(6, 21);
            label_NomeCarta.Name = "label_NomeCarta";
            label_NomeCarta.Size = new Size(43, 15);
            label_NomeCarta.TabIndex = 3;
            label_NomeCarta.Text = "Nome:";
            // 
            // textBox_Busca
            // 
            textBox_Busca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Busca.Location = new Point(6, 39);
            textBox_Busca.Name = "textBox_Busca";
            textBox_Busca.Size = new Size(334, 23);
            textBox_Busca.TabIndex = 2;
            textBox_Busca.TextChanged += textBox_Busca_TextChanged;
            // 
            // dataGridView_Cartas
            // 
            dataGridView_Cartas.AllowUserToAddRows = false;
            dataGridView_Cartas.AllowUserToDeleteRows = false;
            dataGridView_Cartas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Cartas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Cartas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Cartas.Columns.AddRange(new DataGridViewColumn[] { Id, dataGridViewImageColumn1, dataGridViewTextBoxColumn1 });
            dataGridView_Cartas.Location = new Point(6, 68);
            dataGridView_Cartas.Name = "dataGridView_Cartas";
            dataGridView_Cartas.Size = new Size(334, 368);
            dataGridView_Cartas.TabIndex = 1;
            dataGridView_Cartas.DoubleClick += dataGridView_Cartas_DoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.FillWeight = 40.60914F;
            dataGridViewImageColumn1.HeaderText = "Imagem";
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 159.390869F;
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Form_CriarDeck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 572);
            Controls.Add(groupBox_Cartas);
            Controls.Add(groupBox_Baralho);
            Controls.Add(controleComum1);
            Name = "Form_CriarDeck";
            Text = "Form_CriarDeck";
            Load += Form_CriarDeck_Load;
            groupBox_Baralho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Baralho).EndInit();
            groupBox_Cartas.ResumeLayout(false);
            groupBox_Cartas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cartas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ControleComum controleComum1;
        private GroupBox groupBox_Baralho;
        private GroupBox groupBox_Cartas;
        private DataGridView dataGridView_Baralho;
        private DataGridViewImageColumn Imagem;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private Label label_NomeCarta;
        private TextBox textBox_Busca;
        private DataGridView dataGridView_Cartas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}