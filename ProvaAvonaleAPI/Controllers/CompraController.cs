using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaAvonaleAPI.Data;

namespace ProvaAvonaleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly DataContext _context;
        public CompraController(DataContext dataContext) { _context = dataContext; }

        [HttpPost]
        public async Task<ActionResult<List<Compra>>> addCompra(Compra compra)
        {          
            if (compra.Valor <= 100)
                compra.Estado = "REJEITADO";
            else
                compra.Estado = "APROVADO";
            _context.Compras.Add(compra);
            await _context.SaveChangesAsync();

            return Ok(await _context.Compras.ToListAsync());
        }
            
    }
}
