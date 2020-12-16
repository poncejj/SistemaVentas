using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsReferencia
    {
        public clsReferencia()
        {
        }

        public clsReferencia(int id_referencia, String nombre_referencia)
        {
            this.id_referencia = id_referencia;
            this.nombre_referencia = nombre_referencia;
        }

        public int id_referencia { get; set; }
        public String nombre_referencia { get; set; }
    }
}