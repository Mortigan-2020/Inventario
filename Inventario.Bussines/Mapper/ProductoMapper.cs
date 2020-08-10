using Inventario.DataAccessLayer.Entidades;
using Inventario.Bussines.DTO;

namespace Inventario.Bussines.Mapper
{
  public static  class ProductoMapper
    {
        public static ProductoDTO Map(Productos producto)
        {
            return new ProductoDTO
            {
                IdProducto = producto.IdProducto,
                Descripcion = producto.Descripcion,
                Nombre = producto.Nombre,
                Precio = producto.Precio
            };
        }

        public static Productos Map(ProductoDTO producto)
        {
            return new Productos
            {
                IdProducto = producto.IdProducto,
                Descripcion = producto.Descripcion,
                Nombre = producto.Nombre,
                Precio = producto.Precio
            };
        }

    }
}
