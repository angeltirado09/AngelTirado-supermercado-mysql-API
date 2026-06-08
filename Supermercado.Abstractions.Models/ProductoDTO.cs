using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Abstractions.Models
{
    public class ProductoDTO
    {
        public string Nombre { get; set; } = null!;

        public string Marca { get; set; } = null!;

        public string Precio { get; set; } = null!;

        public string Stock { get; set; } = null!;
    }
}
