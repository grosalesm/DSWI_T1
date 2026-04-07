using DSWI_T1_RosalesGian.Dtos;

namespace DSWI_T1_RosalesGian.Services
{
    public interface IProductoService
    {
        IEnumerable<ProductoDto> GetAllProductos();
        ProductoDto GetProductoById(int id);
        void AddProducto(ProductoDto dto);
        void UpdateProducto(int id, ProductoDto dto);
    }
}