namespace Proj_TCC
{
    partial class Form_Login
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
            pan_Painel = new Panel();
            button_FazerLogin = new Button();
            linkLabel_CriarConta = new LinkLabel();
            label_SemConta = new Label();
            linkLabel_RecuperarSenha = new LinkLabel();
            label_EsqueceuSenha = new Label();
            groupBox_Senha = new GroupBox();
            textBox_Senha = new TextBox();
            label_Login = new Label();
            groupBox_Email = new GroupBox();
            textBox_Email = new TextBox();
            pan_Painel.SuspendLayout();
            groupBox_Senha.SuspendLayout();
            groupBox_Email.SuspendLayout();
            SuspendLayout();
            // 
            // pan_Painel
            // 
            pan_Painel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pan_Painel.BackColor = SystemColors.ControlLight;
            pan_Painel.Controls.Add(button_FazerLogin);
            pan_Painel.Controls.Add(linkLabel_CriarConta);
            pan_Painel.Controls.Add(label_SemConta);
            pan_Painel.Controls.Add(linkLabel_RecuperarSenha);
            pan_Painel.Controls.Add(label_EsqueceuSenha);
            pan_Painel.Controls.Add(groupBox_Senha);
            pan_Painel.Controls.Add(label_Login);
            pan_Painel.Controls.Add(groupBox_Email);
            pan_Painel.Location = new Point(192, 12);
            pan_Painel.Name = "pan_Painel";
            pan_Painel.Size = new Size(412, 413);
            pan_Painel.TabIndex = 0;
            // 
            // button_FazerLogin
            // 
            button_FazerLogin.Location = new Point(120, 235);
            button_FazerLogin.Name = "button_FazerLogin";
            button_FazerLogin.Size = new Size(162, 39);
            button_FazerLogin.TabIndex = 8;
            button_FazerLogin.Text = "Fazer Login";
            button_FazerLogin.UseVisualStyleBackColor = true;
            button_FazerLogin.Click += button_FazerLogin_Click;
            // 
            // linkLabel_CriarConta
            // 
            linkLabel_CriarConta.AutoSize = true;
            linkLabel_CriarConta.Location = new Point(301, 370);
            linkLabel_CriarConta.Name = "linkLabel_CriarConta";
            linkLabel_CriarConta.Size = new Size(65, 15);
            linkLabel_CriarConta.TabIndex = 7;
            linkLabel_CriarConta.TabStop = true;
            linkLabel_CriarConta.Text = "Criar conta";
            linkLabel_CriarConta.LinkClicked += linkLabel_CriarConta_LinkClicked;
            // 
            // label_SemConta
            // 
            label_SemConta.AutoSize = true;
            label_SemConta.Location = new Point(58, 370);
            label_SemConta.Name = "label_SemConta";
            label_SemConta.Size = new Size(118, 15);
            label_SemConta.TabIndex = 6;
            label_SemConta.Text = "Não tem uma conta?";
            // 
            // linkLabel_RecuperarSenha
            // 
            linkLabel_RecuperarSenha.AutoSize = true;
            linkLabel_RecuperarSenha.Location = new Point(275, 181);
            linkLabel_RecuperarSenha.Name = "linkLabel_RecuperarSenha";
            linkLabel_RecuperarSenha.Size = new Size(94, 15);
            linkLabel_RecuperarSenha.TabIndex = 5;
            linkLabel_RecuperarSenha.TabStop = true;
            linkLabel_RecuperarSenha.Text = "Recuperar senha";
            // 
            // label_EsqueceuSenha
            // 
            label_EsqueceuSenha.AutoSize = true;
            label_EsqueceuSenha.Location = new Point(58, 181);
            label_EsqueceuSenha.Name = "label_EsqueceuSenha";
            label_EsqueceuSenha.Size = new Size(117, 15);
            label_EsqueceuSenha.TabIndex = 4;
            label_EsqueceuSenha.Text = "Esqueceu sua senha?";
            // 
            // groupBox_Senha
            // 
            groupBox_Senha.Anchor = AnchorStyles.Top;
            groupBox_Senha.Controls.Add(textBox_Senha);
            groupBox_Senha.Location = new Point(55, 125);
            groupBox_Senha.Name = "groupBox_Senha";
            groupBox_Senha.Size = new Size(314, 53);
            groupBox_Senha.TabIndex = 3;
            groupBox_Senha.TabStop = false;
            groupBox_Senha.Text = "Senha";
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
            label_Login.Location = new Point(148, 18);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(99, 45);
            label_Login.TabIndex = 2;
            label_Login.Text = "Login";
            label_Login.Click += label_Login_Click;
            // 
            // groupBox_Email
            // 
            groupBox_Email.Anchor = AnchorStyles.Top;
            groupBox_Email.Controls.Add(textBox_Email);
            groupBox_Email.Location = new Point(55, 66);
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
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(pan_Painel);
            Name = "Form_Login";
            Text = "Form_Login";
            pan_Painel.ResumeLayout(false);
            pan_Painel.PerformLayout();
            groupBox_Senha.ResumeLayout(false);
            groupBox_Senha.PerformLayout();
            groupBox_Email.ResumeLayout(false);
            groupBox_Email.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_Painel;
        private Label label_Login;
        private GroupBox groupBox_Email;
        private TextBox textBox_Email;
        private LinkLabel linkLabel_RecuperarSenha;
        private Label label_EsqueceuSenha;
        private GroupBox groupBox_Senha;
        private TextBox textBox_Senha;
        private LinkLabel linkLabel_CriarConta;
        private Label label_SemConta;
        private Button button_FazerLogin;
    }
}