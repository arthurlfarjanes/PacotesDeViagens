using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacotesDeViagens
{
    public partial class frmExibirReserva : Form
    {
        List<Reserva> reservas;
        public frmExibirReserva(List<Reserva> reservas)
        {
            InitializeComponent();
            this.reservas = reservas;

            foreach (Reserva reserva in reservas)
            {
                ListViewItem Item = new ListViewItem(reserva.Id.ToString());
                Item.SubItems.Add(reserva.Status);
                listViewReservas.Items.Add(Item);
            }
        }

        private void frmExibirReserva_Load(object sender, EventArgs e)
        {

        }
    }
}