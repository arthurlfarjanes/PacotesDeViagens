using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacotesDeViagens
{
    public class Reserva
    {
        private int _id; //teste
        private string _status;
      

        public int Id { get { return _id; } set { _id = value; } }
        public string Status { get { return _status; } set { _status = value; } }
    }
}
