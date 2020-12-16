using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsPaquete
    {
        public clsPaquete()
        {
        }

        public clsPaquete(int id_paquete, String fecha_paquete, int id_cliente, double subtotal_paquete, double valor_total_paquete,
        bool estado_paquete )
        {
            this.id_paquete = id_paquete;
            this.fecha_paquete = fecha_paquete;
            this.id_cliente = id_cliente;
            this.subtotal_paquete = subtotal_paquete;
            this.valor_total_paquete = valor_total_paquete;
            this.estado_paquete = estado_paquete;
        }

        public int id_paquete { get; set; }
        public string fecha_paquete { get; set; }
        public int id_cliente { get; set; }
        public double subtotal_paquete { get; set; }
        public double valor_total_paquete { get; set; }
        public bool estado_paquete { get; set; }

    }
}
