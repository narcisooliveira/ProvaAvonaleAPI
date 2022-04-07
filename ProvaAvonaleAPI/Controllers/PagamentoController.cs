using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaAvonaleAPI.Data;

namespace ProvaAvonaleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public PagamentoController(DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<List<Pagamento>>> addPagamento(Pagamento pagamento)
        {
            if (pagamento.Valor <= 100)
                pagamento.Estado = "REJEITADO";
            else
                pagamento.Estado = "APROVADO";
            _context.Pagamentos.Add(pagamento);
            await _context.SaveChangesAsync();

            return Ok(await _context.Compras.ToListAsync());
        }
    }
}
