using Inventario.Bussines.DTO;

namespace Inventario.Bussines.Contratos
{
  public  interface IProductoServicio
    {
        ProductoDTO Get(int Id_Producto);
    }
}
