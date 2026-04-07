namespace DSWI_T1_RosalesGian.Dtos
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }
        public string NomProducto { get; set; } = null!;
        public decimal? Precio { get; set; }
    }
}