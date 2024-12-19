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
            this.SuspendLayout();
            // 
            // listViewReservas
            // 
            this.listViewReservas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdReserva,
            this.StatusReserva});
            this.listViewReservas.HideSelection = false;
            this.listViewReservas.Location = new System.Drawing.Point(281, 29);
            this.listViewReservas.MultiSelect = false;
            this.listViewReservas.Name = "listViewReservas";
            this.listViewReservas.Size = new System.Drawing.Size(225, 278);
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
            // frmExibirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 319);
            this.Controls.Add(this.listViewReservas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExibirReserva";
            this.Text = "frmExibirReserva";
            this.Load += new System.EventHandler(this.frmExibirReserva_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewReservas;
        private System.Windows.Forms.ColumnHeader IdReserva;
        private System.Windows.Forms.ColumnHeader StatusReserva;
    }
}