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
            panel1 = new Panel();
            label_Login = new Label();
            groupBox_Email = new GroupBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            groupBox_Email.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label_Login);
            panel1.Controls.Add(groupBox_Email);
            panel1.Location = new Point(192, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 413);
            panel1.TabIndex = 0;
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
            groupBox_Email.Controls.Add(textBox1);
            groupBox_Email.Location = new Point(55, 66);
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(55, 125);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 181);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 4;
            label1.Text = "Esqueceu sua senha?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(275, 181);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 370);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 6;
            label2.Text = "Não tem uma conta?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(301, 370);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(65, 15);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Criar conta";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form_Login";
            Text = "Form_Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox_Email.ResumeLayout(false);
            groupBox_Email.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_Login;
        private GroupBox groupBox_Email;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel2;
        private Label label2;
    }
}