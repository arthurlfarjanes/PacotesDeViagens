namespace PacotesDeViagens
{
    partial class frmExibirReserva
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
            this.listViewReservas = new System.Windows.Forms.ListView();
            this.IdReserva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusReserva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewReservas
            // 
            this.listViewReservas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdReserva,
            this.StatusReserva});
            this.listViewReservas.FullRowSelect = true;
            this.listViewReservas.HideSelection = false;
            this.listViewReservas.Location = new System.Drawing.Point(211, 24);
            this.listViewReservas.Margin = new System.Windows.Forms.Padding(2);
            this.listViewReservas.MultiSelect = false;
            this.listViewReservas.Name = "listViewReservas";
            this.listViewReservas.OwnerDraw = true;
            this.listViewReservas.Size = new System.Drawing.Size(170, 227);
            this.listViewReservas.TabIndex = 0;
            this.listViewReservas.UseCompatibleStateImageBehavior = false;
            this.listViewReservas.View = System.Windows.Forms.View.Details;
            // 
            // IdReserva
            // 
            this.IdReserva.Text = "ID";
            this.IdReserva.Width = 86;
            // 
            // StatusReserva
            // 
            this.StatusReserva.Text = "Status";
            this.StatusReserva.Width = 135;
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmarReserva.Location = new System.Drawing.Point(26, 24);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(133, 27);
            this.btnConfirmarReserva.TabIndex = 1;
            this.btnConfirmarReserva.Text = "Confirmar Reserva";
            this.btnConfirmarReserva.UseVisualStyleBackColor = false;
            this.btnConfirmarReserva.Click += new System.EventHandler(this.btnConfirmarReserva_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.BackColor = System.Drawing.Color.Red;
            this.btnCancelarReserva.Location = new System.Drawing.Point(26, 70);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(133, 26);
            this.btnCancelarReserva.TabIndex = 2;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = false;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // frmExibirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 259);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnConfirmarReserva);
            this.Controls.Add(this.listViewReservas);
            this.Name = "frmExibirReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExibirReserva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewReservas;
        private System.Windows.Forms.ColumnHeader IdReserva;
        private System.Windows.Forms.ColumnHeader StatusReserva;
        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.Button btnCancelarReserva;
    }
}