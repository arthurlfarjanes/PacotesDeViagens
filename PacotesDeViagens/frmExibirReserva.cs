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
                listViewReservas.Items.Add(Item);
            }
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se há uma linha selecionada no ListView
                if (listViewReservas.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma reserva para confirmar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pega o ID da reserva selecionada
                int idReserva = int.Parse(listViewReservas.SelectedItems[0].SubItems[0].Text);

                // Encontra a reserva correspondente
                Reserva reserva = reservas.FirstOrDefault(r => r.Id == idReserva);
                if (reserva != null)
                {
                    // Chama o método ConfirmarReserva da classe Reserva
                    string resultado = reserva.ConfirmarReserva(clientes);

                    // Se a reserva foi confirmada com sucesso, atualiza o ListView
                    if (reserva.Status == "Confirmada")
                    {
                        // Atualiza o status no ListView
                        listViewReservas.SelectedItems[0].SubItems[1].Text = "Confirmada";
                    }

                    // Exibe a mensagem retornada do método
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reserva não encontrada. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro
                MessageBox.Show($"Erro ao confirmar a reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
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
                    // Chama o método de cancelamento
                    string resultado = reserva.CancelarReserva(clientes);

                    // Exibe a mensagem de resultado
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza a exibição no ListView, se necessário
                    listViewReservas.SelectedItems[0].SubItems[1].Text = reserva.Status;
                }
                else
                {
                    MessageBox.Show("Reserva não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}