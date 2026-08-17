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
            lista_de_Decks1 = new Lista_de_Decks();
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
            // lista_de_Decks1
            // 
            lista_de_Decks1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lista_de_Decks1.GroupBoxText = "";
            lista_de_Decks1.Location = new Point(12, 159);
            lista_de_Decks1.Name = "lista_de_Decks1";
            lista_de_Decks1.Size = new Size(776, 279);
            lista_de_Decks1.TabIndex = 2;
            // 
            // Meus_Decks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lista_de_Decks1);
            Controls.Add(label1);
            Controls.Add(controleComum1);
            Name = "Meus_Decks";
            Text = "Meus_Decks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ControleComum controleComum1;
        private Label label1;
        private Lista_de_Decks lista_de_Decks1;
    }
}