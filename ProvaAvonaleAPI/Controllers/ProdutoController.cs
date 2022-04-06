using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaAvonaleAPI.Data;

namespace ProvaAvonaleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {     
        private readonly DataContext _context;

        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> Get()
        {
            return Ok(await _context.Produtos.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return BadRequest("Ocorreu um erro desconhecido");
            }return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<List<Produto>>> AddProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return Ok(await _context.Produtos.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> Delete(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if(produto == null)
            {
                return BadRequest("Ocorreu um erro desconhecido");
            }     
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return Ok(await _context.Produtos.ToListAsync());
        }
    }
}
