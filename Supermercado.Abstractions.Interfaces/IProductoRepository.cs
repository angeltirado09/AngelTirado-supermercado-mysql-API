using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermercado.Abstractions.Models;

namespace Supermercado.Abstractions.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<ProductoDTO>> GetStockBajo();
    }
}
