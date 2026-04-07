using DSWI_T1_RosalesGian.Dtos;
using DSWI_T1_RosalesGian.Services;
using Microsoft.AspNetCore.Mvc;

namespace DSWI_T1_RosalesGian.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListProductos()
        {
            var productos = _productoService.GetAllProductos();
            return View(productos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new ProductoDto());
        }

        [HttpPost]
        public IActionResult Create(ProductoDto dto)
        {
            if (ModelState.IsValid)
            {
                _productoService.AddProducto(dto);
                return RedirectToAction(nameof(ListProductos));
            }
            return View(dto);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dto = _productoService.GetProductoById(id);
            if (dto == null)
            {
                return NotFound();
            }
            return View(dto);
        }

        [HttpPost]
        public IActionResult Edit(ProductoDto dto)
        {
            if (ModelState.IsValid)
            {
                _productoService.UpdateProducto(dto.IdProducto, dto);
                return RedirectToAction(nameof(ListProductos));
            }
            return View(dto);
        }
    }
}