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

            //Recebendo valor da data da viagem
            DateTime dataviagem = dtpDataViagem.Value;

            //Validação para não permitir datas anteriores ao dia atual (no caso, ao usuário executar o programa)
            if (dataviagem < DateTime.Now.Date)
            {
                MessageBox.Show("Por favor, selecione uma data a partir de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Recebendo valor da data do regresso
            DateTime dataregresso = dtpDataRegresso.Value;

            //Validação para não permitir datas anteriores da data de ida
            if (dataregresso < dataviagem)
            {
                MessageBox.Show("A data de regresso não pode ser anterior à data de ida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            //Validação para obrigar que o usuário digite algo no campo destino
            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show("O campo 'Destino' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validação para evitar que o usuário digite mais que 50 caracteres no campo de Destino
            else if (txtDestino.Text.Length > 50) 
            {
                MessageBox.Show("O destino não pode ter mais de 50 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                
            } else
            {
                //Recebe o textbox Destino
                string Destino = txtDestino.Text;
            }  

            //Validação para verificar se o nome do hotel ou local de hospedagem foi informado.
            if (string.IsNullOrWhiteSpace(txtHospedagem.Text))
            {
                MessageBox.Show("O campo 'Hospedagem' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validação para que o nome da Hospedagem não seja preenchido com letras e símbolos
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtHospedagem.Text, @"^[a-zA-Z\s]+$")) 
            {
                MessageBox.Show("O nome da hospedagem deve conter apenas letras e espaços.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                //Recebe o textbox Hospedagem
                string Hospedagem = txtHospedagem.Text;
            }            

            // Validação para verificar se a quantidade de noites é maior que zero
            if (nudQuantNoites.Value <= 0)
            {
                MessageBox.Show("A quantidade de noites deve ser um número inteiro positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            } else
            {
                //Recebe a quantidade de Noites
                int QuantidadeNoites = Convert.ToInt16(nudQuantNoites.Value);
            }            

            // Validação para verificar se a quantidade de dias disponíveis é maior que zero
            if (nudQuantDisponivel.Value <= 0)
            {
                MessageBox.Show("A quantidade de dias disponíveis deve ser um número positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            } else
            {
                //Recebe a quantidade Disponível
                int QuantidadeDisponível = Convert.ToInt16(nudQuantDisponivel);
            }            

            // Validação para verificar se o valor do pacote é maior que zero
            if (nudValorPacote.Value <= 0)
            {
                MessageBox.Show("O valor do pacote deve ser um número positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                //Recebe o valor do Pacote
                int ValorPacote = Convert.ToInt16(nudValorPacote.Value);
            }

        }
    }
}