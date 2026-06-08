using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermercado.Abstractions.Models;
using Supermercado.Data.EF;
using Supermercado.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Supermercado.Data.Repositories
{
    public class ProductoRepository(SupermercadoDBContext _context) : IProductoRepository
    {
        public async Task<List<ProductoDTO>> GetStockBajo()
        {
            var bebidasStockBajo = await (
                            from p in _context.Productos
                            where p.IsDeleted == false
                               && p.Categoria == "Bebidas"
                               && Convert.ToInt32(p.Stock) < 5
                            select new ProductoDTO
                            {
                                Nombre = p.Nombre,
                                Marca = p.Marca,
                                Stock = p.Stock,
                                Precio = p.Precio
                            }
                            ).ToListAsync();

            return bebidasStockBajo;
        }
    }
}
