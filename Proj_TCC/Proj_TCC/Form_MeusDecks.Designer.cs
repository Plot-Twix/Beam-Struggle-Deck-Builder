namespace Proj_TCC
{
    partial class Meus_Decks
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
            label1 = new Label();
            groupBox_MeusDecks = new GroupBox();
            dataGridView_MeusDecks = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Favorito = new DataGridViewCheckBoxColumn();
            Delecao_Bloqueada = new DataGridViewCheckBoxColumn();
            button_NovoDeck = new Button();
            groupBox_MeusDecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MeusDecks).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(184, 41);
            label1.TabIndex = 1;
            label1.Text = "Meus Decks";
            // 
            // groupBox_MeusDecks
            // 
            groupBox_MeusDecks.Controls.Add(dataGridView_MeusDecks);
            groupBox_MeusDecks.Location = new Point(12, 159);
            groupBox_MeusDecks.Name = "groupBox_MeusDecks";
            groupBox_MeusDecks.Size = new Size(776, 279);
            groupBox_MeusDecks.TabIndex = 2;
            groupBox_MeusDecks.TabStop = false;
            // 
            // dataGridView_MeusDecks
            // 
            dataGridView_MeusDecks.AllowUserToAddRows = false;
            dataGridView_MeusDecks.AllowUserToDeleteRows = false;
            dataGridView_MeusDecks.AllowUserToOrderColumns = true;
            dataGridView_MeusDecks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_MeusDecks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_MeusDecks.Columns.AddRange(new DataGridViewColumn[] { Nome, Favorito, Delecao_Bloqueada });
            dataGridView_MeusDecks.Dock = DockStyle.Fill;
            dataGridView_MeusDecks.Location = new Point(3, 19);
            dataGridView_MeusDecks.Name = "dataGridView_MeusDecks";
            dataGridView_MeusDecks.Size = new Size(770, 257);
            dataGridView_MeusDecks.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Favorito
            // 
            Favorito.HeaderText = "Favorito";
            Favorito.Name = "Favorito";
            // 
            // Delecao_Bloqueada
            // 
            Delecao_Bloqueada.HeaderText = "🔒";
            Delecao_Bloqueada.Name = "Delecao_Bloqueada";
            // 
            // button_NovoDeck
            // 
            button_NovoDeck.Location = new Point(15, 444);
            button_NovoDeck.Name = "button_NovoDeck";
            button_NovoDeck.Size = new Size(113, 23);
            button_NovoDeck.TabIndex = 3;
            button_NovoDeck.Text = "Novo Baralho";
            button_NovoDeck.UseVisualStyleBackColor = true;
            button_NovoDeck.Click += button_NovoDeck_Click;
            // 
            // Meus_Decks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(button_NovoDeck);
            Controls.Add(groupBox_MeusDecks);
            Controls.Add(label1);
            Controls.Add(controleComum1);
            Name = "Meus_Decks";
            Text = "Meus_Decks";
            Load += Meus_Decks_Load;
            groupBox_MeusDecks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_MeusDecks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ControleComum controleComum1;
        private Label label1;
        private GroupBox groupBox_MeusDecks;
        private DataGridView dataGridView_MeusDecks;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewCheckBoxColumn Favorito;
        private DataGridViewCheckBoxColumn Delecao_Bloqueada;
        private Button button_NovoDeck;
    }
}