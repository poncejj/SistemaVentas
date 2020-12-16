using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsTamano
    {
        public clsTamano()
        {
        }

        public clsTamano(int id_tamano, String nombre_tamano, String letra_tamano)
        {
            this.id_tamano = id_tamano;
            this.nombre_tamano = nombre_tamano;
            this.letra_tamano = letra_tamano;
        }

        public int id_tamano {get;set;} 
        public String nombre_tamano {get;set;}
        public String letra_tamano { get; set; }
    }
}
