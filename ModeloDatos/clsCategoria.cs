using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsCategoria
    {
        public clsCategoria(int id_categoria, String nombre_categoria, String descripcion_categoria)
        {
            this.id_categoria = id_categoria;
            this.nombre_categoria = nombre_categoria;
            this.descripcion_categoria = descripcion_categoria;
        }

        public clsCategoria()
        {
        }


        public int id_categoria {get;set;}
        public String nombre_categoria {get;set;}
        public String descripcion_categoria { get; set; }
    }
}
