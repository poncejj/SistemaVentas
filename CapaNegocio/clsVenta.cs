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
        bool estado_venta )
        {
            this.id_venta = id_venta;
            this.fecha_venta = fecha_venta;
            this.id_cliente = id_cliente;
            this.subtotal_venta = subtotal_venta;
            this.valor_total_venta = valor_total_venta;
            this.estado_venta = estado_venta;
        }

        int id_venta { get; set; }
        String fecha_venta { get; set; }
        int id_cliente { get; set; }
        double subtotal_venta { get; set; }
        double valor_total_venta { get; set; }
        bool estado_venta { get; set; }
    }
}
