using DSWI_T1_RosalesGian.Data;
using DSWI_T1_RosalesGian.Models;

namespace DSWI_T1_RosalesGian.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddProducto(Producto producto)
        {
            _appDbContext.Productos.Add(producto);
            _appDbContext.SaveChanges();
        }

        public void DeleteProducto(int id)
        {
            var producto = GetProductoById(id);
            if (producto != null)
            {
                _appDbContext.Productos.Remove(producto);
                _appDbContext.SaveChanges();
            }
        }

        public IEnumerable<Producto> GetProductos()
        {
            return _appDbContext.Productos.ToList();
        }

        public Producto GetProductoById(int id)
        {
            return _appDbContext.Productos.Find(id);
        }

        public void UpdateProducto(Producto producto)
        {
            _appDbContext.Productos.Update(producto);
            _appDbContext.SaveChanges();
        }
    }
}