using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PacotesDeViagens
{
    public class Reserva
    {
        private int _id;
        private string _status;
        private List<Pacote> _pacotes;
        private string _cpfCliente;


        public int Id { get { return _id; } set { _id = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public List<Pacote> Pacotes { get { return _pacotes; } set {_pacotes = value; } }
        public string CpfCliente
        {
            get { return _cpfCliente; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^\d{11}$"))
                {
                    throw new ArgumentException("CPF inválido. Deve conter exatamente 11 dígitos numéricos.");
                }
                _cpfCliente = value;
            }
        }

        public Reserva(int id, string status, List<Pacote> pacotes)
        {
            Id = id; 
            Status = status; 
            Pacotes = pacotes;
        }

        public double CalcularValorTotal()
        {
            double valorTotal = 0;

            foreach (var pacote in Pacotes)
            {
                valorTotal += pacote.Valor * pacote.QuantidadeDisponivel;
            }

            return valorTotal;
        }
    }
}
