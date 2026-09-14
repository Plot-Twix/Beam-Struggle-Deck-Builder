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
            button_FazerLogin = new Button();
            groupBox2 = new GroupBox();
            textBox_Apelido = new TextBox();
            groupBox1 = new GroupBox();
            textBox_Senha = new TextBox();
            label_Login = new Label();
            groupBox_Email = new GroupBox();
            textBox_Email = new TextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox_Email.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button_FazerLogin);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label_Login);
            panel1.Controls.Add(groupBox_Email);
            panel1.Location = new Point(192, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 413);
            panel1.TabIndex = 0;
            // 
            // button_FazerLogin
            // 
            button_FazerLogin.Location = new Point(128, 272);
            button_FazerLogin.Name = "button_FazerLogin";
            button_FazerLogin.Size = new Size(162, 39);
            button_FazerLogin.TabIndex = 9;
            button_FazerLogin.Text = "Criar Conta";
            button_FazerLogin.UseVisualStyleBackColor = true;
            button_FazerLogin.Click += button_FazerLogin_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(textBox_Apelido);
            groupBox2.Location = new Point(54, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 53);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nome de Usuário";
            // 
            // textBox_Apelido
            // 
            textBox_Apelido.Dock = DockStyle.Fill;
            textBox_Apelido.Location = new Point(3, 19);
            textBox_Apelido.Name = "textBox_Apelido";
            textBox_Apelido.Size = new Size(308, 23);
            textBox_Apelido.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(textBox_Senha);
            groupBox1.Location = new Point(57, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 53);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senha";
            // 
            // textBox_Senha
            // 
            textBox_Senha.Dock = DockStyle.Fill;
            textBox_Senha.Location = new Point(3, 19);
            textBox_Senha.Name = "textBox_Senha";
            textBox_Senha.Size = new Size(308, 23);
            textBox_Senha.TabIndex = 0;
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
            groupBox_Email.Controls.Add(textBox_Email);
            groupBox_Email.Location = new Point(57, 154);
            groupBox_Email.Name = "groupBox_Email";
            groupBox_Email.Size = new Size(314, 53);
            groupBox_Email.TabIndex = 1;
            groupBox_Email.TabStop = false;
            groupBox_Email.Text = "E-mail";
            // 
            // textBox_Email
            // 
            textBox_Email.Dock = DockStyle.Fill;
            textBox_Email.Location = new Point(3, 19);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(308, 23);
            textBox_Email.TabIndex = 0;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox_Email.ResumeLayout(false);
            groupBox_Email.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_Login;
        private GroupBox groupBox_Email;
        private TextBox textBox_Email;
        private GroupBox groupBox1;
        private TextBox textBox_Senha;
        private GroupBox groupBox2;
        private TextBox textBox_Apelido;
        private Button button_FazerLogin;
    }
}