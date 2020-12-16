using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsMarca
    {
        public clsMarca()
        {
        }

        public clsMarca(int id_marca, String nombre_marca, String pais_marca)
        {
            this.id_marca = id_marca;
            this.nombre_marca = nombre_marca;
            this.pais_marca = pais_marca;
        }

        public int id_marca { get; set; }
        public String nombre_marca { get; set; }
        public String pais_marca { get; set; }
    }
}
