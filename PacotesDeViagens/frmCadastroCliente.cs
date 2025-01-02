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
            //Validação do CPF
            string cpf = masktextboxCPF.Text;
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                MessageBox.Show("Por favor, preencha o CPF corretamente (11 números, formato 000.000.000-00).",
                                "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (new string(cpf[0], cpf.Length) == cpf)
            {
                MessageBox.Show("CPF inválido! Todos os números não podem ser iguais.",
                                "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            if (cpf[9] - '0' != digito1 || cpf[10] - '0' != digito2)
            {
                MessageBox.Show("CPF inválido! Verifique os números informados.",
                                "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar Nome

            string nome = txtNome.Text.Trim();
            int espacos = nome.Split(' ').Length - 1;

            if (espacos < 1) // Se houver menos de um sobrenome
            {
                MessageBox.Show("Por favor, insira o nome completo (nome e sobrenome).",
                                "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



                //Cadastra o Cliente
                clientes.Add(new Cliente(
                masktextboxCPF.Text,
                txtNome.Text,
                txtSexo.Text,
                txtLogradouro.Text,
                txtCidade.Text,
                txtEstado.Text,
                txtPais.Text,
                Convert.ToDouble(NumericSaldo.Value)
            ));

            MessageBox.Show("Cadastrado com sucesso!");
        }



        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}