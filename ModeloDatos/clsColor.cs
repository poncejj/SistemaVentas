using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsColor
    {
        public clsColor()
        {
        }

        public clsColor(int id_color, String nombre_color)
        {
            this.id_color = id_color;
            this.nombre_color = nombre_color;
        }

        public int id_color { get; set; }
        public String nombre_color { get; set; }

    }
}
