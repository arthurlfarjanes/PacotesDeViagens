using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PacotesDeViagens
{
    public partial class frmExibirReserva : Form
    {
        List<Reserva> reservas;
        List<Cliente> clientes;

        public frmExibirReserva(List<Reserva> reservas, List<Cliente> clientes)
        {
            InitializeComponent();
            this.reservas = reservas;
            this.clientes = clientes;

            // Exibe as reservas no ListView
            foreach (Reserva reserva in reservas)
            {
                ListViewItem Item = new ListViewItem(reserva.Id.ToString());
                Item.SubItems.Add(reserva.Status);
                lvReservas.Items.Add(Item);
            }
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            // Verifica se uma reserva foi selecionada no ListView
            if (lvReservas.SelectedItems.Count > 0)
            {
                // Pega o ID da reserva selecionada
                int idReserva = int.Parse(lvReservas.SelectedItems[0].SubItems[0].Text);

                // Encontra a reserva correspondente
                Reserva reserva = reservas.FirstOrDefault(r => r.Id == idReserva);
                if (reserva != null)
                {
                    // Verifica se o status da reserva é "Cancelada"
                    if (reserva.Status == "Cancelada")
                    {
                        MessageBox.Show("Não é possível confirmar uma reserva que foi cancelada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Impede a execução do restante do código
                    }

                    // Verifica se o status da reserva já é "Confirmada"
                    if (reserva.Status == "Confirmada")
                    {
                        MessageBox.Show("Esta reserva já foi confirmada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Impede a confirmação
                    }

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
                    lvReservas.SelectedItems[0].SubItems[1].Text = "Confirmada";

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show($"Reserva confirmada com sucesso!\nCliente: {cliente.Nome}\nSaldo atualizado: R$ {cliente.Saldo:F2}",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            // Verifica se uma reserva foi selecionada no ListView
            if (lvReservas.SelectedItems.Count > 0)
            {
                // Pega o ID da reserva selecionada
                int idReserva = int.Parse(lvReservas.SelectedItems[0].SubItems[0].Text);

                // Encontra a reserva correspondente
                Reserva reserva = reservas.FirstOrDefault(r => r.Id == idReserva);
                if (reserva != null)
                {
                    // Verifica se o status da reserva é "Confirmada"
                    if (reserva.Status == "Confirmada")
                    {
                        MessageBox.Show("Não é possível cancelar uma reserva que já foi confirmada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Impede a execução do restante do código
                    }

                    // Localiza o cliente associado à reserva pelo CPF
                    Cliente cliente = clientes.FirstOrDefault(c => c.CPF == reserva.CpfCliente);

                    if (cliente == null)
                    {
                        MessageBox.Show("Cliente associado à reserva não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Atualiza o status da reserva para "Cancelada"
                    reserva.Status = "Cancelada";

                    // Atualiza o status no ListView
                    lvReservas.SelectedItems[0].SubItems[1].Text = "Cancelada";

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Reserva cancelada com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}