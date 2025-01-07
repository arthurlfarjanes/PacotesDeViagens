namespace PacotesDeViagens
{
    partial class frmCadastroPacote
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDataViagem = new System.Windows.Forms.Label();
            this.numericValorPacote = new System.Windows.Forms.NumericUpDown();
            this.lblValorPacote = new System.Windows.Forms.Label();
            this.lblDetalhesPacote = new System.Windows.Forms.Label();
            this.txtDetalhesPacote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorPacote)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "AM";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(12, 43);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 0;
            // 
            // lblDataViagem
            // 
            this.lblDataViagem.AutoSize = true;
            this.lblDataViagem.Location = new System.Drawing.Point(13, 24);
            this.lblDataViagem.Name = "lblDataViagem";
            this.lblDataViagem.Size = new System.Drawing.Size(83, 13);
            this.lblDataViagem.TabIndex = 1;
            this.lblDataViagem.Text = "Data da Viagem";
            // 
            // numericValorPacote
            // 
            this.numericValorPacote.Location = new System.Drawing.Point(12, 266);
            this.numericValorPacote.Name = "numericValorPacote";
            this.numericValorPacote.Size = new System.Drawing.Size(120, 20);
            this.numericValorPacote.TabIndex = 2;
            // 
            // lblValorPacote
            // 
            this.lblValorPacote.AutoSize = true;
            this.lblValorPacote.Location = new System.Drawing.Point(13, 250);
            this.lblValorPacote.Name = "lblValorPacote";
            this.lblValorPacote.Size = new System.Drawing.Size(83, 13);
            this.lblValorPacote.TabIndex = 3;
            this.lblValorPacote.Text = "Valor do Pacote";
            // 
            // lblDetalhesPacote
            // 
            this.lblDetalhesPacote.AutoSize = true;
            this.lblDetalhesPacote.Location = new System.Drawing.Point(13, 140);
            this.lblDetalhesPacote.Name = "lblDetalhesPacote";
            this.lblDetalhesPacote.Size = new System.Drawing.Size(154, 13);
            this.lblDetalhesPacote.TabIndex = 4;
            this.lblDetalhesPacote.Text = "Detalhes do Pacote da Viagem";
            // 
            // txtDetalhesPacote
            // 
            this.txtDetalhesPacote.Location = new System.Drawing.Point(12, 156);
            this.txtDetalhesPacote.Name = "txtDetalhesPacote";
            this.txtDetalhesPacote.Size = new System.Drawing.Size(200, 20);
            this.txtDetalhesPacote.TabIndex = 5;
            // 
            // frmCadastroPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 350);
            this.Controls.Add(this.txtDetalhesPacote);
            this.Controls.Add(this.lblDetalhesPacote);
            this.Controls.Add(this.lblValorPacote);
            this.Controls.Add(this.numericValorPacote);
            this.Controls.Add(this.lblDataViagem);
            this.Controls.Add(this.dtpData);
            this.Name = "frmCadastroPacote";
            this.Text = "Cadastro de Pacote de Viagem";
            ((System.ComponentModel.ISupportInitialize)(this.numericValorPacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDataViagem;
        private System.Windows.Forms.NumericUpDown numericValorPacote;
        private System.Windows.Forms.Label lblValorPacote;
        private System.Windows.Forms.Label lblDetalhesPacote;
        private System.Windows.Forms.TextBox txtDetalhesPacote;
    }
}