namespace Proj_TCC
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lista_de_Decks1 = new Lista_de_Decks();
            controleComum1 = new ControleComum();
            SuspendLayout();
            // 
            // lista_de_Decks1
            // 
            lista_de_Decks1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lista_de_Decks1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lista_de_Decks1.GroupBoxText = "Decks Compartilhados Recentemente";
            lista_de_Decks1.Location = new Point(12, 118);
            lista_de_Decks1.Name = "lista_de_Decks1";
            lista_de_Decks1.Size = new Size(681, 171);
            lista_de_Decks1.TabIndex = 1;
            lista_de_Decks1.Load += Lista_de_Decks_Load;
            // 
            // controleComum1
            // 
            controleComum1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            controleComum1.AutoSize = true;
            controleComum1.Location = new Point(0, 0);
            controleComum1.Name = "controleComum1";
            controleComum1.Size = new Size(807, 112);
            controleComum1.TabIndex = 2;
            controleComum1.TextChanged += ControleComum1_TextChanged_1;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(controleComum1);
            Controls.Add(lista_de_Decks1);
            Name = "TelaInicial";
            Text = "Nome do Projeto";
            Load += TelaInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Lista_de_Decks lista_de_Decks1;
        private ControleComum controleComum1;
    }
}
