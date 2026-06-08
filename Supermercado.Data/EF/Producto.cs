using System;
using System.Collections.Generic;

namespace Supermercado.Data.EF;

public partial class Producto
{
    public long ProductosId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string Precio { get; set; } = null!;

    public string Stock { get; set; } = null!;

    public string? CapacidadMl { get; set; }

    public string? CapacidadMg { get; set; }

    public bool IsDeleted { get; set; }
}
