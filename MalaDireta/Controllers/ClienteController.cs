using MalaDireta.Context;
using MalaDireta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MalaDireta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("clientes")]
        public ActionResult<IEnumerable<Cliente>> GetClientes() 
        {
            try
            {
                var clientes = _context.Clientes.AsNoTracking().ToList();
                if (!clientes.Any()) { return NotFound("Não há clientes!"); }
                return Ok(clientes);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                               "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpGet("{id:int}", Name ="ObterCliente")]
        public ActionResult<Cliente> GetCliente(int id) 
        {
            try
            {
                var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
                if (cliente == null) { return NotFound("Não encontrado cliente com o número {id}");  }
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public ActionResult Post(Cliente cliente) { }

        [HttpPut("{id:int}")]
        public ActionResult Put(Cliente cliente) {  return Ok(cliente); }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) { }
    }
}
