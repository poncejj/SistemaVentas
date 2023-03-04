﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsDetalleVenta
    {
        public clsDetalleVenta()
        {
        }

        public int id_detalle_venta { get; set; }
        public int id_venta { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_producto { get; set; }
        public decimal total_detalle { get; set; }
        public bool estado_detalle { get; set; }
        public int id_detalle_paquete { get; set; }
        public int id_paquete { get; set; }
        public int id_color { get; set; }
        public int id_tamano { get; set; }
        public string observacion_detalle_venta { get; set; }

    }
}
