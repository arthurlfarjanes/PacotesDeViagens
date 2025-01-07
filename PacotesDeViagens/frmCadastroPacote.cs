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
        int id = 0;
        public frmCadastroPacote(List<Pacote> pacotes)
        {
            InitializeComponent();
            this.pacotes = pacotes;
            
        }

        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            id += 1;

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
            }       

            // Validação para verificar se a quantidade de noites é maior que zero
            if (nudQuantNoites.Value <= 0)
            {
                MessageBox.Show("A quantidade de noites deve ser um número inteiro positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }       

            // Validação para verificar se a quantidade de dias disponíveis é maior que zero
            if (nudQuantDisponivel.Value <= 0)
            {
                MessageBox.Show("A quantidade de dias disponíveis deve ser um número positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }         

            // Validação para verificar se o valor do pacote é maior que zero
            if (nudValorPacote.Value <= 0)
            {
                MessageBox.Show("O valor do pacote deve ser um número positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            // Validação para verificar se o campo Detalhes está vazio ou contém apenas espaços
            if (string.IsNullOrWhiteSpace(rtxDetalhes.Text))
            {
                MessageBox.Show("O campo 'Detalhes' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validação para verificar se o campo Detalhes contém mais de 500 caracteres (exemplo)
            else if (rtxDetalhes.Text.Length > 500)
            {
                MessageBox.Show("O campo 'Detalhes' não pode exceder 500 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Se você quiser verificar um conteúdo específico ou um formato (exemplo: não permitir números), pode usar Regex
            else if (System.Text.RegularExpressions.Regex.IsMatch(rtxDetalhes.Text, @"\d")) // Exemplo: verifica se há números
            {
                MessageBox.Show("O campo 'Detalhes' não pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tentativa de criar o Pacote
            Pacote novoPacote = new Pacote(
                id,
                dataviagem,
                dataregresso,
                nudQuantNoites.Value,
                nudValorPacote.Value,
                nudQuantDisponivel.Value,
                rtxDetalhes.Text,
                txtDestino.Text,
                txtHospedagem.Text
            );

            // Adicionando à lista se válido
            pacotes.Add(novoPacote);

            // Exibindo mensagem de sucesso
            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar campos após o cadastro
            LimparCampos();
        }

        // Método para limpar os campos do formulário
        private void LimparCampos()
        {
            // Limpar os campos de texto
            txtDestino.Clear();
            txtHospedagem.Clear();
            rtxDetalhes.Clear();

            // Resetar os campos de data
            dtpDataViagem.Value = DateTime.Now;
            dtpDataRegresso.Value = DateTime.Now;

            // Resetar os controles NumericUpDown
            nudQuantNoites.Value = nudQuantNoites.Minimum;
            nudQuantDisponivel.Value = nudQuantDisponivel.Minimum;
            nudValorPacote.Value = nudValorPacote.Minimum;
        }
    }
}