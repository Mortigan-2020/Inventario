using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Bussines.DTO
{
  public  class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public byte[] Descripcion { get; set; }
        public double Precio { get; set; }


    }
}
