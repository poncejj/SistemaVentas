using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsPago
    {
        public clsPago()
        {
        }

        public clsPago(int idPago,string fecha,int idVenta,decimal valor)
        {
            this.idPago = idPago;
            this.fecha = fecha;
            this.idVenta = idVenta;
            this.valor = valor;
        }

        int idPago {get;set;}
        string fecha {get;set;}
        int idVenta {get;set;}
        decimal valor { get; set; }
    }
}
