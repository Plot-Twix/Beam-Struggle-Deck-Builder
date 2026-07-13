namespace Proj_TCC
{
    partial class Form_VerUsuario
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
            vScrollBar1 = new VScrollBar();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            lista_de_Decks1 = new Lista_de_Decks();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(783, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 450);
            vScrollBar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lista_de_Decks1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 460);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Visualizar Usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(134, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(628, 51);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nome de Usuário";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(616, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(134, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(628, 51);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(616, 23);
            textBox2.TabIndex = 0;
            // 
            // lista_de_Decks1
            // 
            lista_de_Decks1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lista_de_Decks1.GroupBoxText = "groupBox1";
            lista_de_Decks1.Location = new Point(6, 173);
            lista_de_Decks1.Name = "lista_de_Decks1";
            lista_de_Decks1.Size = new Size(750, 281);
            lista_de_Decks1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(656, 22);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Salvar Mudanças";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form_VerUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(vScrollBar1);
            Controls.Add(controleComum1);
            Name = "Form_VerUsuario";
            Text = "Form_VerUsuario";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ControleComum controleComum1;
        private VScrollBar vScrollBar1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button1;
        private Lista_de_Decks lista_de_Decks1;
    }
}