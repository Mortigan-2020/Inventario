using Inventario.Bussines.Contratos;
using Inventario.Bussines.DTO;
using Inventario.Bussines.Mapper;
using Inventario.DataAccessLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Bussines.Servicios
{
   public class ProductoServicio : IProductoServicio
    {
        _InventarioContext context = new _InventarioContext();
        public ProductoDTO Get(int Id_Producto)
        {
         var producto = context.Productos.Find(Id_Producto);
            return ProductoMapper.Map(producto);
        }
    }
}
