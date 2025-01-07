namespace PacotesDeViagens
{
    partial class frmCadastroCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.NumericSaldo = new System.Windows.Forms.NumericUpDown();
            this.CadastrarCliente = new System.Windows.Forms.Button();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnOutro = new System.Windows.Forms.RadioButton();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(72, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(72, 162);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(308, 22);
            this.txtLogradouro.TabIndex = 3;
            this.txtLogradouro.Text = "Rua";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(72, 225);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(204, 22);
            this.txtCidade.TabIndex = 4;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(72, 286);
            this.txtPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(308, 22);
            this.txtPais.TabIndex = 6;
            // 
            // NumericSaldo
            // 
            this.NumericSaldo.Location = new System.Drawing.Point(72, 342);
            this.NumericSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumericSaldo.Name = "NumericSaldo";
            this.NumericSaldo.Size = new System.Drawing.Size(164, 22);
            this.NumericSaldo.TabIndex = 7;
            // 
            // CadastrarCliente
            // 
            this.CadastrarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.CadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CadastrarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CadastrarCliente.Location = new System.Drawing.Point(72, 394);
            this.CadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CadastrarCliente.Name = "CadastrarCliente";
            this.CadastrarCliente.Size = new System.Drawing.Size(309, 33);
            this.CadastrarCliente.TabIndex = 8;
            this.CadastrarCliente.Text = "Cadastrar";
            this.CadastrarCliente.UseVisualStyleBackColor = false;
            this.CadastrarCliente.Click += new System.EventHandler(this.CadastrarCliente_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCpf.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCpf.Location = new System.Drawing.Point(71, 79);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "CPF";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNomeCompleto.Location = new System.Drawing.Point(71, 17);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(147, 20);
            this.lblNomeCompleto.TabIndex = 10;
            this.lblNomeCompleto.Text = "NOME COMPLETO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(304, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "SEXO";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLogradouro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLogradouro.Location = new System.Drawing.Point(68, 140);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(126, 20);
            this.lblLogradouro.TabIndex = 12;
            this.lblLogradouro.Text = "LOGRADOURO";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCidade.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCidade.Location = new System.Drawing.Point(69, 203);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(71, 20);
            this.lblCidade.TabIndex = 13;
            this.lblCidade.Text = "CIDADE";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblEstado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEstado.Location = new System.Drawing.Point(284, 203);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 20);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblPais.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPais.Location = new System.Drawing.Point(71, 263);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(46, 20);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "PAÍS";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSaldo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSaldo.Location = new System.Drawing.Point(68, 324);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(64, 20);
            this.lblSaldo.TabIndex = 16;
            this.lblSaldo.Text = "SALDO";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(308, 44);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(39, 20);
            this.rbtnMasculino.TabIndex = 18;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(308, 73);
            this.rbtnFeminino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(36, 20);
            this.rbtnFeminino.TabIndex = 19;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnOutro
            // 
            this.rbtnOutro.AutoSize = true;
            this.rbtnOutro.Location = new System.Drawing.Point(308, 101);
            this.rbtnOutro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnOutro.Name = "rbtnOutro";
            this.rbtnOutro.Size = new System.Drawing.Size(60, 20);
            this.rbtnOutro.TabIndex = 20;
            this.rbtnOutro.TabStop = true;
            this.rbtnOutro.Text = "Outro";
            this.rbtnOutro.UseVisualStyleBackColor = true;
            // 
            // maskCPF
            // 
            this.maskCPF.HidePromptOnLeave = true;
            this.maskCPF.Location = new System.Drawing.Point(73, 101);
            this.maskCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskCPF.Mask = "000,000,000-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(204, 22);
            this.maskCPF.TabIndex = 21;
            this.maskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbEstados
            // 
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstados.Location = new System.Drawing.Point(288, 225);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(93, 24);
            this.cmbEstados.TabIndex = 22;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 452);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.rbtnOutro);
            this.Controls.Add(this.rbtnFeminino);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.CadastrarCliente);
            this.Controls.Add(this.NumericSaldo);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.NumericSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.NumericUpDown NumericSaldo;
        private System.Windows.Forms.Button CadastrarCliente;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnOutro;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.ComboBox cmbEstados;
    }
}