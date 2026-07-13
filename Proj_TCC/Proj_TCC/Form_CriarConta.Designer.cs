namespace Proj_TCC
{
    partial class Form_CriarConta
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label_Login = new Label();
            groupBox_Email = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox_Email.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label_Login);
            panel1.Controls.Add(groupBox_Email);
            panel1.Location = new Point(192, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 413);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(57, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 53);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 23);
            textBox2.TabIndex = 0;
            // 
            // label_Login
            // 
            label_Login.Anchor = AnchorStyles.Top;
            label_Login.AutoSize = true;
            label_Login.Font = new Font("Segoe UI", 24F);
            label_Login.Location = new Point(111, 24);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(179, 45);
            label_Login.TabIndex = 2;
            label_Login.Text = "Criar Conta";
            label_Login.Click += label_CriarConta_Click;
            // 
            // groupBox_Email
            // 
            groupBox_Email.Anchor = AnchorStyles.Top;
            groupBox_Email.Controls.Add(textBox1);
            groupBox_Email.Location = new Point(57, 154);
            groupBox_Email.Name = "groupBox_Email";
            groupBox_Email.Size = new Size(314, 53);
            groupBox_Email.TabIndex = 1;
            groupBox_Email.TabStop = false;
            groupBox_Email.Text = "E-mail";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(54, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 53);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nome de Usuário";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(3, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 23);
            textBox3.TabIndex = 0;
            // 
            // Form_CriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form_CriarConta";
            Text = "Form_CriarConta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox_Email.ResumeLayout(false);
            groupBox_Email.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_Login;
        private GroupBox groupBox_Email;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox3;
    }
}