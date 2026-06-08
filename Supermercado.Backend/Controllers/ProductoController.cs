using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Supermercado.Abstractions.Interfaces;
using Supermercado.Abstractions.Models;

namespace Supermercado.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController(IProductoRepository _productoRepository) : ControllerBase
    {
        [HttpGet("getStockBajo")]
        public async Task<List<ProductoDTO>> GetStockBajo()
        {
            return await _productoRepository.GetStockBajo();
        }
    }
}
