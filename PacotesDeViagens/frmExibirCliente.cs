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
    public partial class frmExibirCliente : Form
    {
        List<Cliente> clientes;
        public frmExibirCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;

            foreach (Cliente cliente in clientes)
            {
                ListViewItem item = new ListViewItem(cliente.CPF);
                item.SubItems.Add(cliente.Nome);
                item.SubItems.Add(cliente.Sexo);
                item.SubItems.Add(cliente.Logradouro);
                item.SubItems.Add(cliente.Cidade);
                item.SubItems.Add(cliente.Estado);
                item.SubItems.Add(cliente.Pais);
                item.SubItems.Add(cliente.Saldo.ToString("N2"));

                // Adicionar o item ao ListView
                listViewClientes.Items.Add(item);

            }
        }

        private void btnAdicionarSaldo_Click(object sender, EventArgs e)
        {
            if (listViewClientes.SelectedItems.Count > 0) {
                string cpfCliente = listViewClientes.SelectedItems[0].SubItems[0].Text;

                Cliente cliente = clientes.FirstOrDefault(c => c.CPF == cpfCliente);

                if (cliente != null)
                {
                    double valor = Convert.ToDouble(nudEditarSaldo.Value);
                    if (valor <= 0)
                    {
                        MessageBox.Show("Valor Inválido! Digite algo maior que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Impede a execução do restante do código
                    }

                    cliente.AdicionarSaldo(valor);
                    MessageBox.Show("Saldo Atualizado com sucesso!");
                    nudEditarSaldo.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a execução do restante do código
            }
        }

        private void btnDescontarSaldo_Click(object sender, EventArgs e)
        {
            if (listViewClientes.SelectedItems.Count > 0)
            {
                string cpfCliente = listViewClientes.SelectedItems[0].SubItems[0].Text;

                Cliente cliente = clientes.FirstOrDefault(c => c.CPF == cpfCliente);

                if (cliente != null)
                {
                    double valor = Convert.ToDouble(nudEditarSaldo.Value);
                    if (valor <= 0)
                    {
                        MessageBox.Show("Valor Inválido! Digite algo maior que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Impede a execução do restante do código
                    }
                    else if (valor > cliente.Saldo)
                    {
                        MessageBox.Show("Valor Inválido! Digite algo menor que o saldo atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Impede a execução do restante do código
                    }

                    cliente.DescontarSaldo(valor);
                    MessageBox.Show("Saldo Atualizado com sucesso!");
                    nudEditarSaldo.Value = 0;
                } else
                {
                    MessageBox.Show("Selecione um cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Impede a execução do restante do código
                }
            }
        }
    }


    }
