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
        List<Cliente> clientes;

        public frmExibirReserva(List<Reserva> reservas, List<Cliente>clientes)
        {
            InitializeComponent();
            this.reservas = reservas;
            this.clientes = clientes;

            // Exibe as reservas no ListView
            foreach (Reserva reserva in reservas)
            {
                ListViewItem Item = new ListViewItem(reserva.Id.ToString());
                Item.SubItems.Add(reserva.Status);
                listViewReservas.Items.Add(Item);
            }
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            // Verifica se uma reserva foi selecionada no ListView
            if (listViewReservas.SelectedItems.Count > 0)
            {
                // Pega o ID da reserva selecionada
                int idReserva = int.Parse(listViewReservas.SelectedItems[0].SubItems[0].Text);

                // Encontra a reserva correspondente
                Reserva reserva = reservas.FirstOrDefault(r => r.Id == idReserva);
                if (reserva != null)
                {
                    // Localiza o cliente associado à reserva pelo CPF
                    Cliente cliente = clientes.FirstOrDefault(c => c.CPF == reserva.CpfCliente);

                    if (cliente == null)
                    {
                        MessageBox.Show("Cliente associado à reserva não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Calcula o valor total da reserva
                    double valorTotalReserva = reserva.CalcularValorTotal();  // Supondo que há um método para calcular o valor total

                    // Verifica se o cliente possui saldo suficiente
                    if (cliente.Saldo < valorTotalReserva)
                    {
                        MessageBox.Show("Saldo insuficiente para confirmar a reserva.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Deduz o valor da reserva do saldo do cliente
                    cliente.Saldo -= valorTotalReserva;

                    // Atualiza o status da reserva para "Confirmada"
                    reserva.Status = "Confirmada";

                    // Atualiza o status no ListView
                    listViewReservas.SelectedItems[0].SubItems[1].Text = "Confirmada";

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show($"Reserva confirmada com sucesso!\nCliente: {cliente.Nome}\nSaldo atualizado: R$ {cliente.Saldo:F2}",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                // Caso nenhum item tenha sido selecionado
                MessageBox.Show("Selecione uma reserva para confirmar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


