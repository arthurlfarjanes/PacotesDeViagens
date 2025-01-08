namespace PacotesDeViagens
{
    partial class frmExibirCliente
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
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.CpfColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SexoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LograColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaisColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaldoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdicionarSaldo = new System.Windows.Forms.Button();
            this.btnDescontarSaldo = new System.Windows.Forms.Button();
            this.nudEditarSaldo = new System.Windows.Forms.NumericUpDown();
            this.lblEditarSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewClientes
            // 
            this.listViewClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CpfColuna,
            this.NomeColuna,
            this.SexoColuna,
            this.LograColuna,
            this.CidadeColuna,
            this.EstadoColuna,
            this.PaisColuna,
            this.SaldoColuna});
            this.listViewClientes.FullRowSelect = true;
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(7, 11);
            this.listViewClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(561, 242);
            this.listViewClientes.TabIndex = 0;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.View = System.Windows.Forms.View.Details;
            // 
            // CpfColuna
            // 
            this.CpfColuna.Text = "CPF";
            this.CpfColuna.Width = 128;
            // 
            // NomeColuna
            // 
            this.NomeColuna.Text = "Nome";
            this.NomeColuna.Width = 101;
            // 
            // SexoColuna
            // 
            this.SexoColuna.Text = "Sexo";
            this.SexoColuna.Width = 76;
            // 
            // LograColuna
            // 
            this.LograColuna.Text = "Logradouro";
            this.LograColuna.Width = 87;
            // 
            // CidadeColuna
            // 
            this.CidadeColuna.Text = "Cidade";
            this.CidadeColuna.Width = 78;
            // 
            // EstadoColuna
            // 
            this.EstadoColuna.Text = "Estado";
            this.EstadoColuna.Width = 87;
            // 
            // PaisColuna
            // 
            this.PaisColuna.Text = "País";
            this.PaisColuna.Width = 78;
            // 
            // SaldoColuna
            // 
            this.SaldoColuna.Text = "Saldo";
            this.SaldoColuna.Width = 81;
            // 
            // btnAdicionarSaldo
            // 
            this.btnAdicionarSaldo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdicionarSaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSaldo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionarSaldo.Location = new System.Drawing.Point(7, 312);
            this.btnAdicionarSaldo.Name = "btnAdicionarSaldo";
            this.btnAdicionarSaldo.Size = new System.Drawing.Size(113, 23);
            this.btnAdicionarSaldo.TabIndex = 2;
            this.btnAdicionarSaldo.Text = "Adicionar Saldo";
            this.btnAdicionarSaldo.UseVisualStyleBackColor = false;
            this.btnAdicionarSaldo.Click += new System.EventHandler(this.btnAdicionarSaldo_Click);
            // 
            // btnDescontarSaldo
            // 
            this.btnDescontarSaldo.BackColor = System.Drawing.Color.SlateGray;
            this.btnDescontarSaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescontarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescontarSaldo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDescontarSaldo.Location = new System.Drawing.Point(126, 312);
            this.btnDescontarSaldo.Name = "btnDescontarSaldo";
            this.btnDescontarSaldo.Size = new System.Drawing.Size(113, 23);
            this.btnDescontarSaldo.TabIndex = 3;
            this.btnDescontarSaldo.Text = "Descontar Saldo";
            this.btnDescontarSaldo.UseVisualStyleBackColor = false;
            this.btnDescontarSaldo.Click += new System.EventHandler(this.btnDescontarSaldo_Click);
            // 
            // nudEditarSaldo
            // 
            this.nudEditarSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudEditarSaldo.Location = new System.Drawing.Point(7, 286);
            this.nudEditarSaldo.Name = "nudEditarSaldo";
            this.nudEditarSaldo.Size = new System.Drawing.Size(232, 20);
            this.nudEditarSaldo.TabIndex = 7;
            // 
            // lblEditarSaldo
            // 
            this.lblEditarSaldo.AutoSize = true;
            this.lblEditarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblEditarSaldo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEditarSaldo.Location = new System.Drawing.Point(4, 267);
            this.lblEditarSaldo.Name = "lblEditarSaldo";
            this.lblEditarSaldo.Size = new System.Drawing.Size(81, 16);
            this.lblEditarSaldo.TabIndex = 8;
            this.lblEditarSaldo.Text = "Editar Saldo";
            // 
            // frmExibirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 344);
            this.Controls.Add(this.lblEditarSaldo);
            this.Controls.Add(this.nudEditarSaldo);
            this.Controls.Add(this.btnDescontarSaldo);
            this.Controls.Add(this.btnAdicionarSaldo);
            this.Controls.Add(this.listViewClientes);
            this.Name = "frmExibirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Cadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewClientes;
        private System.Windows.Forms.ColumnHeader CpfColuna;
        private System.Windows.Forms.ColumnHeader NomeColuna;
        private System.Windows.Forms.ColumnHeader SexoColuna;
        private System.Windows.Forms.ColumnHeader LograColuna;
        private System.Windows.Forms.ColumnHeader CidadeColuna;
        private System.Windows.Forms.ColumnHeader EstadoColuna;
        private System.Windows.Forms.ColumnHeader PaisColuna;
        private System.Windows.Forms.ColumnHeader SaldoColuna;
        private System.Windows.Forms.Button btnAdicionarSaldo;
        private System.Windows.Forms.Button btnDescontarSaldo;
        private System.Windows.Forms.NumericUpDown nudEditarSaldo;
        private System.Windows.Forms.Label lblEditarSaldo;
    }
}