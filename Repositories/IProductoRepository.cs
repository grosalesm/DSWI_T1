using DSWI_T1_RosalesGian.Models;

namespace DSWI_T1_RosalesGian.Repositories
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetProductos();
        Producto GetProductoById(int id);
        void AddProducto(Producto producto);
        void UpdateProducto(Producto producto);
        void DeleteProducto(int id);
    }
}
