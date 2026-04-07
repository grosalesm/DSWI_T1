using DSWI_T1_RosalesGian.Dtos;
using DSWI_T1_RosalesGian.Models;

namespace DSWI_T1_RosalesGian.Utils
{
    public class ProductoMapper
    {
        public static Producto toProducto(ProductoDto dto)
        {
            Producto producto = new Producto();
            producto.IdProducto = dto.IdProducto;
            producto.NomProducto = dto.NomProducto;
            producto.Precio = dto.Precio;

            return producto;
        }

        public static ProductoDto toProductoDto(Producto producto)
        {
            ProductoDto dto = new ProductoDto();
            dto.IdProducto = producto.IdProducto;
            dto.NomProducto = producto.NomProducto;
            dto.Precio = producto.Precio;

            return dto;
        }
    }
}