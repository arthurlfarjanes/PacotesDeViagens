namespace PacotesDeViagens
{
    partial class frmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.lerToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacoteToolStripMenuItem1,
            this.reservaToolStripMenuItem1,
            this.clienteToolStripMenuItem1});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // pacoteToolStripMenuItem1
            // 
            this.pacoteToolStripMenuItem1.Name = "pacoteToolStripMenuItem1";
            this.pacoteToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pacoteToolStripMenuItem1.Text = "Pacote";
            this.pacoteToolStripMenuItem1.Click += new System.EventHandler(this.pacoteToolStripMenuItem1_Click);
            // 
            // reservaToolStripMenuItem1
            // 
            this.reservaToolStripMenuItem1.Name = "reservaToolStripMenuItem1";
            this.reservaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.reservaToolStripMenuItem1.Text = "Reserva";
            this.reservaToolStripMenuItem1.Click += new System.EventHandler(this.reservaToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // lerToolStripMenuItem
            // 
            this.lerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacoteToolStripMenuItem,
            this.reservaToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.lerToolStripMenuItem.Name = "lerToolStripMenuItem";
            this.lerToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.lerToolStripMenuItem.Text = "Exibir";
            // 
            // pacoteToolStripMenuItem
            // 
            this.pacoteToolStripMenuItem.Name = "pacoteToolStripMenuItem";
            this.pacoteToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.pacoteToolStripMenuItem.Text = "Pacote";
            this.pacoteToolStripMenuItem.Click += new System.EventHandler(this.pacoteToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.reservaToolStripMenuItem.Text = "Reserva";
            this.reservaToolStripMenuItem.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Gerenciamento de Viagens";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
    }
}

