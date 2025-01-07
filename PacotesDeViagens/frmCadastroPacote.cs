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
    public partial class frmCadastroPacote : Form
    {
        List<Pacote> pacotes;
        public frmCadastroPacote(List<Pacote> pacotes)
        {
            InitializeComponent();
            this.pacotes = pacotes;
        }

        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Recebendo valor da data da viagem
                DateTime dataviagem = dtpDataViagem.Value;

                //Recebendo valor da data do regresso
                DateTime dataregresso = dtpDataRegresso.Value;

                //Recebe o textbox Destino
                string Destino = txtDestino.Text;

                //Recebe o textbox Hospedagem
                string Hospedagem = txtHospedagem.Text;

                //Recebe a quantidade de Noites
                int QuantidadeNoites = Convert.ToInt16(nudQuantNoites.Value);

                //Recebe a quantidade Disponível
                int QuantidadeDisponível = Convert.ToInt16(nudQuantDisponivel);

                //Recebe o valor do Pacote
                int ValorPacote = Convert.ToInt16(nudValorPacote.Value);


            }
        }
    }
}