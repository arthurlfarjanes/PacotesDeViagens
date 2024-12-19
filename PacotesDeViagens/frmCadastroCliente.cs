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
           // clientes.Add(clientes. );
            //List<Cliente> clientes = new List<Cliente>();
           // veiculoList.Add(new Veiculo(txtPlaca.Text, cmbMarca.Text, cmbModelo.Text, Convert.ToInt16(numAno.Value)));
            clientes.Add(new Cliente(txtCpf.Text, txtNome.Text, txtSexo.Text, txtLogradouro.Text, txtCidade.Text, txtEstado.Text, txtPais.Text, Convert.ToDouble(NumericSaldo.Value)));
                       
            MessageBox.Show("cadastrado com sucesso!");

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}