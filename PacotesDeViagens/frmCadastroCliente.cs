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
    public partial class frmCadastroCliente : Form
    {
        List<Cliente> clientes;

        public frmCadastroCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtendo o valor do campo "Sexo" com base nos RadioButtons
                string sexo = ObterSexoSelecionado();

                if (string.IsNullOrEmpty(sexo))
                {
                    MessageBox.Show("Por favor, selecione uma opção para o campo 'Sexo'.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tentativa de criar o cliente
                Cliente novoCliente = new Cliente(
                    txtCpf.Text,
                    txtNome.Text,
                    sexo,
                    txtLogradouro.Text,
                    txtCidade.Text,
                    txtEstado.Text,
                    txtPais.Text,
                    Convert.ToDouble(NumericSaldo.Value)
                );

                // Adicionando à lista se válido
                clientes.Add(novoCliente);

                // Exibindo mensagem de sucesso
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar campos após o cadastro
                LimparCampos();
            }
            catch (ArgumentException ex)
            {
                // Captura de validações da classe Cliente
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                // Tratamento de erro ao converter valores numéricos
                MessageBox.Show("O campo Saldo deve conter um valor numérico válido.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Captura de qualquer outro tipo de exceção
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpar os campos após cadastro
        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtPais.Text = string.Empty;
            NumericSaldo.Value = 0;

            // Resetando os RadioButtons
            rbtnMasculino.Checked = false;
            rbtnFeminino.Checked = false;
            rbtnOutro.Checked = false;
        }

        // Método para obter o sexo selecionado pelos RadioButtons
        private string ObterSexoSelecionado()
        {
            if (rbtnMasculino.Checked)
            {
                return "M";
            }
            else if (rbtnFeminino.Checked)
            {
                return "F";
            }
            else if (rbtnOutro.Checked)
            {
                return "Outro";
            }
            return null;
        }
    }
}