using MalaDireta.Context;
using MalaDireta.Models;
using Microsoft.AspNetCore.Mvc;

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
                var clientes = _context.Clientes.ToList();
                if (clientes.Any()) { return NotFound("Escrever"); }
                return Ok(clientes);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                               "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }
    }
}
