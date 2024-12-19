using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PacotesDeViagens
{
    public class Cliente
    {
        private string _cpf;
        private string _nome;
        private string _sexo;
        private string _logradouro;
        private string _cidade;
        private string _estado;
        private string _pais;
        private double _saldo;
       
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        /*public Veiculo(string placa, string marca, string modelo, int ano)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }*/

        public Cliente(string CPF, String Nome, string Sexo, string Logradouro, string Cidade, string Estado, string Pais, double Saldo)
        {
            this.CPF = CPF;
            this.Nome = Nome;
            this.Sexo = Sexo;
            this.Logradouro = Logradouro;
            this.Cidade = Cidade; 
            this.Estado = Estado;
            this.Pais = Pais;
            this.Saldo = Saldo;
        }

        public bool AdicionarSaldo(double valor)
        {
            if (valor <= 0)
            {
                return false;
            }
            else
            {
                this.Saldo = Saldo + valor;
                return true;
            }
        }

        public bool DescontarSaldo(double valor)
        {
            if (valor <= 0 || Saldo <= 0)
            {
                return false;
            }
            else
            {
                this.Saldo = Saldo - valor;
                return true;
            }
        }
    }
}
