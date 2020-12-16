using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsCliente
    {
        public clsCliente()
        {
        }

        public clsCliente(int id_cliente, String identiicacion_cliente, String nombre_cliente, String apellido_cliente,
            String telefono1_cliente, String telefono2_cliente, String domicilio_cliente, String email_cliente, int id_referencia,
            String fecha_registro_cliente)
        {
            this.id_cliente = id_cliente;
            this.identiicacion_cliente = identiicacion_cliente;
            this.nombre_cliente = nombre_cliente;
            this.apellido_cliente = apellido_cliente;
            this.telefono1_cliente = telefono1_cliente;
            this.telefono2_cliente = telefono2_cliente;
            this.domicilio_cliente = domicilio_cliente;
            this.email_cliente = email_cliente;
            this.id_referencia = id_referencia;
            this.fecha_registro_cliente = fecha_registro_cliente;
        }

        public int id_cliente { get; set; }
        public String identiicacion_cliente { get; set; }
        public String nombre_cliente { get; set; }
        public String apellido_cliente { get; set; }
        public String telefono1_cliente { get; set; }
        public String telefono2_cliente { get; set; }
        public String domicilio_cliente { get; set; }
        public String email_cliente { get; set; }
        public int id_referencia { get; set; }
        public String fecha_registro_cliente { get; set; }
        public double saldo_cliente { get; set; }
    }
}
