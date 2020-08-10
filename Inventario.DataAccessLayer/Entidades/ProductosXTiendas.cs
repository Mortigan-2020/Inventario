using System;
using System.Collections.Generic;

namespace Inventario.DataAccessLayer.Entidades
{
    public partial class ProductosXTiendas
    {
        public int IdProducto { get; set; }
        public int IdTienda { get; set; }

        public virtual Productos IdProductoNavigation { get; set; }
        public virtual Tiendas IdTiendaNavigation { get; set; }
    }
}
