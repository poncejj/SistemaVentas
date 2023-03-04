using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class clsProducto
    {
        public clsProducto()
        {
        }

        public clsProducto(int id_producto, String nombre_producto, decimal precio_producto, int id_categoria, int id_color,
            int id_marca, int id_tamano, String fecha_registro, bool estado_producto,int cantidad,string descripcion)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.precio_producto = precio_producto;
            this.id_categoria = id_categoria;
            this.id_color = id_color;
            this.id_marca = id_marca;
            this.id_tamano = id_tamano;
            this.fecha_registro = fecha_registro;
            this.estado_producto = estado_producto;
            this.cantidad = cantidad;
            this.descripcion = descripcion;

        }

        public int id_producto { get; set; }
        public String nombre_producto { get; set; }
        public decimal precio_producto { get; set; }
        public int id_categoria { get; set; }
        public int id_color { get; set; }
        public int id_marca { get; set; }
        public int id_tamano { get; set; }
        public String fecha_registro { get; set; }
        public bool estado_producto { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
    }
}
