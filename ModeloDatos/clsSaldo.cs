using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsSaldo
    {
        public int id_saldo { get; set; }
        public int id_cliente { get; set; }
        public decimal saldo { get; set; }

        public clsSaldo()
        {
        }

        public clsSaldo(int id_saldo, int id_cliente, decimal saldo)
        {
            this.id_saldo = id_saldo;
            this.id_cliente = id_cliente;
            this.saldo = saldo;
        }
    }
}
