namespace PacotesDeViagens
{
    partial class frmCadastroReserva
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
            this.lblCpfCadReserva = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblIdPacote = new System.Windows.Forms.Label();
            this.txtIDPacote = new System.Windows.Forms.TextBox();
            this.lblQtdPacote = new System.Windows.Forms.Label();
            this.nudQuantidadePacote = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadePacote)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCpfCadReserva
            // 
            this.lblCpfCadReserva.AutoSize = true;
            this.lblCpfCadReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCpfCadReserva.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCpfCadReserva.Location = new System.Drawing.Point(45, 29);
            this.lblCpfCadReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpfCadReserva.Name = "lblCpfCadReserva";
            this.lblCpfCadReserva.Size = new System.Drawing.Size(115, 16);
            this.lblCpfCadReserva.TabIndex = 12;
            this.lblCpfCadReserva.Text = "CPF DO CLIENTE";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(49, 47);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 11;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 20);
            this.txtNome.TabIndex = 11;
            // 
            // lblIdPacote
            // 
            this.lblIdPacote.AutoSize = true;
            this.lblIdPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblIdPacote.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIdPacote.Location = new System.Drawing.Point(45, 77);
            this.lblIdPacote.Name = "lblIdPacote";
            this.lblIdPacote.Size = new System.Drawing.Size(101, 16);
            this.lblIdPacote.TabIndex = 14;
            this.lblIdPacote.Text = "ID DO PACOTE";
            // 
            // txtIDPacote
            // 
            this.txtIDPacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPacote.Location = new System.Drawing.Point(49, 95);
            this.txtIDPacote.Name = "txtIDPacote";
            this.txtIDPacote.Size = new System.Drawing.Size(185, 20);
            this.txtIDPacote.TabIndex = 13;
            // 
            // lblQtdPacote
            // 
            this.lblQtdPacote.AutoSize = true;
            this.lblQtdPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblQtdPacote.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQtdPacote.Location = new System.Drawing.Point(45, 125);
            this.lblQtdPacote.Name = "lblQtdPacote";
            this.lblQtdPacote.Size = new System.Drawing.Size(96, 16);
            this.lblQtdPacote.TabIndex = 19;
            this.lblQtdPacote.Text = "QUANTIDADE";
            // 
            // nudQuantidadePacote
            // 
            this.nudQuantidadePacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantidadePacote.Location = new System.Drawing.Point(49, 144);
            this.nudQuantidadePacote.Name = "nudQuantidadePacote";
            this.nudQuantidadePacote.Size = new System.Drawing.Size(185, 20);
            this.nudQuantidadePacote.TabIndex = 18;
            // 
            // btnCadastrarReserva
            // 
            this.btnCadastrarReserva.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCadastrarReserva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarReserva.Location = new System.Drawing.Point(49, 176);
            this.btnCadastrarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarReserva.Name = "btnCadastrarReserva";
            this.btnCadastrarReserva.Size = new System.Drawing.Size(185, 27);
            this.btnCadastrarReserva.TabIndex = 21;
            this.btnCadastrarReserva.Text = "Cadastrar Reserva";
            this.btnCadastrarReserva.UseVisualStyleBackColor = false;
            this.btnCadastrarReserva.Click += new System.EventHandler(this.btnCadastrarReserva_Click);
            // 
            // frmCadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 237);
            this.Controls.Add(this.btnCadastrarReserva);
            this.Controls.Add(this.lblQtdPacote);
            this.Controls.Add(this.nudQuantidadePacote);
            this.Controls.Add(this.lblIdPacote);
            this.Controls.Add(this.txtIDPacote);
            this.Controls.Add(this.lblCpfCadReserva);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastroReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadePacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCpfCadReserva;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdPacote;
        private System.Windows.Forms.TextBox txtIDPacote;
        private System.Windows.Forms.Label lblQtdPacote;
        private System.Windows.Forms.NumericUpDown nudQuantidadePacote;
        private System.Windows.Forms.Button btnCadastrarReserva;
    }
}