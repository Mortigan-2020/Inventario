using System;
using System.Collections.Generic;

namespace Inventario.DataAccessLayer.Entidades
{
    public partial class Productos
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public byte[] Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
