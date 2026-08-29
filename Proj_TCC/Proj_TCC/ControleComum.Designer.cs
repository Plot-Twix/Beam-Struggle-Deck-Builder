namespace Proj_TCC
{
    partial class ControleComum
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip_Principal = new MenuStrip();
            minhaContaToolStripMenuItem = new ToolStripMenuItem();
            conferirInformaçõesToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            meusDecksToolStripMenuItem = new ToolStripMenuItem();
            meusDecksToolStripMenuItem1 = new ToolStripMenuItem();
            decksPúblicosToolStripMenuItem = new ToolStripMenuItem();
            compToolStripMenuItem = new ToolStripMenuItem();
            procurarCartasToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sumárioToolStripMenuItem = new ToolStripMenuItem();
            índiceToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            panel_Letreiro = new Panel();
            label_Letreiro = new Label();
            menuStrip_Principal.SuspendLayout();
            panel_Letreiro.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_Principal
            // 
            menuStrip_Principal.Dock = DockStyle.None;
            menuStrip_Principal.Items.AddRange(new ToolStripItem[] { minhaContaToolStripMenuItem, meusDecksToolStripMenuItem, procurarCartasToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip_Principal.Location = new Point(0, 88);
            menuStrip_Principal.Name = "menuStrip_Principal";
            menuStrip_Principal.Size = new Size(368, 24);
            menuStrip_Principal.TabIndex = 1;
            menuStrip_Principal.Text = "menuStrip1";
            // 
            // minhaContaToolStripMenuItem
            // 
            minhaContaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conferirInformaçõesToolStripMenuItem, loginToolStripMenuItem, criarContaToolStripMenuItem });
            minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            minhaContaToolStripMenuItem.Size = new Size(88, 20);
            minhaContaToolStripMenuItem.Text = "Minha Conta";
            // 
            // conferirInformaçõesToolStripMenuItem
            // 
            conferirInformaçõesToolStripMenuItem.Name = "conferirInformaçõesToolStripMenuItem";
            conferirInformaçõesToolStripMenuItem.Size = new Size(186, 22);
            conferirInformaçõesToolStripMenuItem.Text = "Conferir Informações";
            conferirInformaçõesToolStripMenuItem.Click += conferirInformaçõesToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(186, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(186, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            // 
            // meusDecksToolStripMenuItem
            // 
            meusDecksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { meusDecksToolStripMenuItem1, decksPúblicosToolStripMenuItem, compToolStripMenuItem });
            meusDecksToolStripMenuItem.Name = "meusDecksToolStripMenuItem";
            meusDecksToolStripMenuItem.Size = new Size(50, 20);
            meusDecksToolStripMenuItem.Text = "Decks";
            // 
            // meusDecksToolStripMenuItem1
            // 
            meusDecksToolStripMenuItem1.Name = "meusDecksToolStripMenuItem1";
            meusDecksToolStripMenuItem1.Size = new Size(200, 22);
            meusDecksToolStripMenuItem1.Text = "Meus Decks";
            // 
            // decksPúblicosToolStripMenuItem
            // 
            decksPúblicosToolStripMenuItem.Name = "decksPúblicosToolStripMenuItem";
            decksPúblicosToolStripMenuItem.Size = new Size(200, 22);
            decksPúblicosToolStripMenuItem.Text = "Decks Públicos";
            // 
            // compToolStripMenuItem
            // 
            compToolStripMenuItem.Name = "compToolStripMenuItem";
            compToolStripMenuItem.Size = new Size(200, 22);
            compToolStripMenuItem.Text = "Compartilhar Meu Deck";
            // 
            // procurarCartasToolStripMenuItem
            // 
            procurarCartasToolStripMenuItem.Name = "procurarCartasToolStripMenuItem";
            procurarCartasToolStripMenuItem.Size = new Size(52, 20);
            procurarCartasToolStripMenuItem.Text = "Cartas";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumárioToolStripMenuItem, índiceToolStripMenuItem, pesquisarToolStripMenuItem, toolStripSeparator5, sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sumárioToolStripMenuItem
            // 
            sumárioToolStripMenuItem.Name = "sumárioToolStripMenuItem";
            sumárioToolStripMenuItem.Size = new Size(124, 22);
            sumárioToolStripMenuItem.Text = "&Sumário";
            // 
            // índiceToolStripMenuItem
            // 
            índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            índiceToolStripMenuItem.Size = new Size(124, 22);
            índiceToolStripMenuItem.Text = "&Índice";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(124, 22);
            pesquisarToolStripMenuItem.Text = "&Pesquisar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(121, 6);
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(124, 22);
            sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // panel_Letreiro
            // 
            panel_Letreiro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_Letreiro.BackColor = Color.SteelBlue;
            panel_Letreiro.Controls.Add(label_Letreiro);
            panel_Letreiro.Location = new Point(0, 0);
            panel_Letreiro.Name = "panel_Letreiro";
            panel_Letreiro.Size = new Size(816, 85);
            panel_Letreiro.TabIndex = 2;
            // 
            // label_Letreiro
            // 
            label_Letreiro.AutoSize = true;
            label_Letreiro.Font = new Font("Noto Serif", 18F, FontStyle.Bold);
            label_Letreiro.ForeColor = Color.Transparent;
            label_Letreiro.Location = new Point(39, 22);
            label_Letreiro.Name = "label_Letreiro";
            label_Letreiro.Size = new Size(220, 35);
            label_Letreiro.TabIndex = 0;
            label_Letreiro.Text = "Nome do Projeto";
            label_Letreiro.TextAlign = ContentAlignment.MiddleLeft;
            label_Letreiro.Click += label_Letreiro_Click;
            // 
            // ControleComum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel_Letreiro);
            Controls.Add(menuStrip_Principal);
            Name = "ControleComum";
            Size = new Size(816, 112);
            menuStrip_Principal.ResumeLayout(false);
            menuStrip_Principal.PerformLayout();
            panel_Letreiro.ResumeLayout(false);
            panel_Letreiro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_Principal;
        private ToolStripMenuItem meusDecksToolStripMenuItem;
        private ToolStripMenuItem meusDecksToolStripMenuItem1;
        private ToolStripMenuItem decksPúblicosToolStripMenuItem;
        private ToolStripMenuItem compToolStripMenuItem;
        private ToolStripMenuItem procurarCartasToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sumárioToolStripMenuItem;
        private ToolStripMenuItem índiceToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem minhaContaToolStripMenuItem;
        private ToolStripMenuItem conferirInformaçõesToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private Panel panel_Letreiro;
        private Label label_Letreiro;
    }
}
