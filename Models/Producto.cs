using System;
using System.Collections.Generic;

namespace DSWI_T1_RosalesGian.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string NomProducto { get; set; } = null!;

    public decimal? Precio { get; set; }
}
