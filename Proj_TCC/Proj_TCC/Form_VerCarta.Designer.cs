namespace Proj_TCC
{
    partial class Form_VerCarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerCarta));
            groupBox9 = new GroupBox();
            groupBox_Texto = new GroupBox();
            label_Texto = new Label();
            groupBox5 = new GroupBox();
            groupBox_Tipos = new GroupBox();
            label_Tipos = new Label();
            groupBox_Nome = new GroupBox();
            label_Nome = new Label();
            groupBox_Imagem = new GroupBox();
            pictureBox_Imagem = new PictureBox();
            groupBox_Texto.SuspendLayout();
            groupBox_Tipos.SuspendLayout();
            groupBox_Nome.SuspendLayout();
            groupBox_Imagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagem).BeginInit();
            SuspendLayout();
            // 
            // groupBox9
            // 
            groupBox9.Location = new Point(748, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(57, 48);
            groupBox9.TabIndex = 11;
            groupBox9.TabStop = false;
            // 
            // groupBox_Texto
            // 
            groupBox_Texto.Controls.Add(label_Texto);
            groupBox_Texto.Location = new Point(301, 115);
            groupBox_Texto.Name = "groupBox_Texto";
            groupBox_Texto.Size = new Size(504, 343);
            groupBox_Texto.TabIndex = 10;
            groupBox_Texto.TabStop = false;
            groupBox_Texto.Text = "Texto";
            // 
            // label_Texto
            // 
            label_Texto.Location = new Point(6, 19);
            label_Texto.Name = "label_Texto";
            label_Texto.Size = new Size(492, 321);
            label_Texto.TabIndex = 0;
            label_Texto.Text = resources.GetString("label_Texto.Text");
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(748, 57);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(57, 52);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            // 
            // groupBox_Tipos
            // 
            groupBox_Tipos.Controls.Add(label_Tipos);
            groupBox_Tipos.Location = new Point(301, 57);
            groupBox_Tipos.Name = "groupBox_Tipos";
            groupBox_Tipos.Size = new Size(441, 52);
            groupBox_Tipos.TabIndex = 6;
            groupBox_Tipos.TabStop = false;
            groupBox_Tipos.Text = "Tipos";
            // 
            // label_Tipos
            // 
            label_Tipos.AutoSize = true;
            label_Tipos.Font = new Font("Segoe UI", 12F);
            label_Tipos.Location = new Point(6, 18);
            label_Tipos.Name = "label_Tipos";
            label_Tipos.Size = new Size(206, 21);
            label_Tipos.TabIndex = 1;
            label_Tipos.Text = "[Tipo 1 | Tipo 2 | Tipo 3 | . . . ]";
            // 
            // groupBox_Nome
            // 
            groupBox_Nome.Controls.Add(label_Nome);
            groupBox_Nome.Location = new Point(301, 3);
            groupBox_Nome.Name = "groupBox_Nome";
            groupBox_Nome.Size = new Size(441, 48);
            groupBox_Nome.TabIndex = 9;
            groupBox_Nome.TabStop = false;
            groupBox_Nome.Text = "Nome";
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Font = new Font("Segoe UI", 12F);
            label_Nome.Location = new Point(6, 19);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(63, 21);
            label_Nome.TabIndex = 0;
            label_Nome.Text = "[Nome]";
            // 
            // groupBox_Imagem
            // 
            groupBox_Imagem.Controls.Add(pictureBox_Imagem);
            groupBox_Imagem.Location = new Point(4, 3);
            groupBox_Imagem.Name = "groupBox_Imagem";
            groupBox_Imagem.Size = new Size(291, 455);
            groupBox_Imagem.TabIndex = 7;
            groupBox_Imagem.TabStop = false;
            groupBox_Imagem.Text = "Carta";
            // 
            // pictureBox_Imagem
            // 
            pictureBox_Imagem.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_Imagem.Location = new Point(6, 22);
            pictureBox_Imagem.Name = "pictureBox_Imagem";
            pictureBox_Imagem.Size = new Size(279, 423);
            pictureBox_Imagem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Imagem.TabIndex = 3;
            pictureBox_Imagem.TabStop = false;
            // 
            // Form_VerCarta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 461);
            Controls.Add(groupBox9);
            Controls.Add(groupBox_Texto);
            Controls.Add(groupBox5);
            Controls.Add(groupBox_Tipos);
            Controls.Add(groupBox_Nome);
            Controls.Add(groupBox_Imagem);
            Name = "Form_VerCarta";
            Text = "Visualizador de Carta";
            groupBox_Texto.ResumeLayout(false);
            groupBox_Tipos.ResumeLayout(false);
            groupBox_Tipos.PerformLayout();
            groupBox_Nome.ResumeLayout(false);
            groupBox_Nome.PerformLayout();
            groupBox_Imagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Imagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox9;
        private GroupBox groupBox_Texto;
        private Label label_Texto;
        private GroupBox groupBox5;
        private GroupBox groupBox_Tipos;
        private Label label_Tipos;
        private GroupBox groupBox_Nome;
        private Label label_Nome;
        private GroupBox groupBox_Imagem;
        private PictureBox pictureBox_Imagem;
    }
}