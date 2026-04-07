using DSWI_T1_RosalesGian.Dtos;
using DSWI_T1_RosalesGian.Models;
using DSWI_T1_RosalesGian.Repositories;
using DSWI_T1_RosalesGian.Utils;

namespace DSWI_T1_RosalesGian.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public void AddProducto(ProductoDto dto)
        {
            _productoRepository.AddProducto(ProductoMapper.toProducto(dto));
        }

        public IEnumerable<ProductoDto> GetAllProductos()
        {
            IEnumerable<Producto> productos = _productoRepository.GetProductos();
            List<ProductoDto> productoDtos = new List<ProductoDto>();

            foreach (var producto in productos)
            {
                productoDtos.Add(ProductoMapper.toProductoDto(producto));
            }

            return productoDtos;
        }

        public ProductoDto GetProductoById(int id)
        {
            var producto = _productoRepository.GetProductoById(id);
            return ProductoMapper.toProductoDto(producto);
        }

        public void UpdateProducto(int id, ProductoDto dto)
        {
            dto.IdProducto = id;
            _productoRepository.UpdateProducto(ProductoMapper.toProducto(dto));
        }
    }
}