using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacotesDeViagens
{
    // Comentário aaaaa
    public class Pacote
    {
        private int _id;
        private DateTime _data;
        private int _quantidadeDeNoites;
        private double _valor;
        private int _quantidadeDisponivel;
        private string _detalhes;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public int QuantidadeDeNoites
        {
            get { return _quantidadeDeNoites; }
            set { _quantidadeDeNoites = value; }
        }
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public int QuantidadeDisponivel
        {
            get { return _quantidadeDisponivel; }
            set { _quantidadeDisponivel = value; }
        }
        public string Detalhes
        {
            get { return _detalhes; }
            set { _detalhes = value; }
        }
    }
}
