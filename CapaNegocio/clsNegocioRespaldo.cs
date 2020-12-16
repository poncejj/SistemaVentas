using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    public class clsNegocioRespaldo
    {
        public void generarResplado(string ruta)
        {
            clsDatosResplado objResplado = new clsDatosResplado();
            objResplado.generarResplado(ruta);
        }
    }
}
