using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsVenta
    {
        public clsVenta()
            {
            }

        public clsVenta(int id_venta, String fecha_venta, int id_cliente, double subtotal_venta, double valor_total_venta,
        int estado_venta )
        {
            this.id_venta = id_venta;
            this.fecha_venta = fecha_venta;
            this.id_cliente = id_cliente;
            this.subtotal_venta = subtotal_venta;
            this.valor_total_venta = valor_total_venta;
            this.estado_venta = estado_venta;
        }

        public int id_venta { get; set; }
        public String fecha_venta { get; set; }
        public int id_cliente { get; set; }
        public double subtotal_venta { get; set; }
        public double valor_total_venta { get; set; }
        public int estado_venta { get; set; }
    }
}
