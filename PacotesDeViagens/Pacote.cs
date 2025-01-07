using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacotesDeViagens
{
    public class Pacote
    {
        private int _id;
        private DateTime _data;
        private DateTime _regresso;
        private int _quantidadeDeNoites;
        private double _valor;
        private int _quantidadeDisponivel;
        private string _detalhes;
        private string _destino;
        private string _hospedagem;


        // Variável que busca a data atual do computador do usuário
        DateTime DataAtual = DateTime.Now;

        public int ID
        {
            get { return _id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id inválido! Informe um número maior que 0.");
                }
                _id = value;
            }
        }
        public DateTime Data
        {
            get { return _data; }
            set
            {
                if (value < DataAtual)
                {
                    throw new ArgumentException("Data inválida! Selecione uma data posterior ou igual à data de hoje.");
                }
                _data = value;
            }
        }
        public int QuantidadeDeNoites
        {
            get { return _quantidadeDeNoites; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Dados Inválidos! Insira a quantidade de noites do pacote.");
                }
                _quantidadeDeNoites = value;
            }
        }
        public double Valor
        {
            get { return _valor; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Valor Inválido! Insira um valor positivo.");
                }
                _valor = value;
            }
        }
        public int QuantidadeDisponivel
        {
            get { return _quantidadeDisponivel; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Dados Inválidos! Digite um número positivo.");
                }
                _quantidadeDisponivel = value;
            }
        }
        public string Detalhes
        {
            get { return _detalhes; }
            set { _detalhes = value; }
        }
        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        //Construtor para receber Cadastro Pacote
        public Pacote(int id, DateTime Data, DateTime Regresso, Decimal QuantidadedeNoites, Decimal Valor, Decimal QuantidadeDisponivel, string Detalhes, string Destino, string Hospedagem)
        {
            this._id = id;
            this._data = Data;
            this._regresso = Regresso;
            this._quantidadeDeNoites = Convert.ToInt16(QuantidadedeNoites);
            this._valor = Convert.ToInt16(Valor);
            this._quantidadeDisponivel = Convert.ToInt16(QuantidadeDisponivel);
            this._detalhes = Detalhes;
            this._destino = Destino;
            this._hospedagem = Hospedagem;
        }
    }
}
