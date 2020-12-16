using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using ModeloDatos;
using System.Data;

namespace CapaNegocio
{
    public class clsNegocioCliente
    {
        clsDatosCliente objDatosCliente = new clsDatosCliente();
        
        public DataSet consultarCliente(int id_nombre)
        {
            return objDatosCliente.consutarCliente(id_nombre);
        }

        public DataSet consultarTodosClientes()
        {
            return objDatosCliente.consutarTodoCliente();
        }

        public bool insertarCliente(clsCliente objCliente)
        {
            return objDatosCliente.insertarCliente(objCliente.identiicacion_cliente,objCliente.nombre_cliente,objCliente.apellido_cliente,
                objCliente.telefono1_cliente, objCliente.telefono2_cliente,objCliente.domicilio_cliente, objCliente.email_cliente,
                objCliente.id_referencia);
        }

        public bool actualizarCliente(clsCliente objCliente)
        {
            return objDatosCliente.modificarCliente(objCliente.id_cliente,objCliente.identiicacion_cliente,objCliente.nombre_cliente,
                objCliente.apellido_cliente,objCliente.telefono1_cliente,objCliente.telefono2_cliente,objCliente.domicilio_cliente,
                objCliente.email_cliente,objCliente.id_referencia);
        }

        public bool eliminarCliente(String identificacion)
        {
            return objDatosCliente.eliminarCliente(identificacion);
        }

        public DataSet comboBoxCliente()
        {
            return objDatosCliente.consutarTodoCliente();
        }

        public DataSet consultarClienteId(int id_cliente)
        {
            return objDatosCliente.consultarClienteId(id_cliente);
        }

        public int consultarUltimoId()
        {
            return objDatosCliente.consultarUltimoId();
        }
    }
}