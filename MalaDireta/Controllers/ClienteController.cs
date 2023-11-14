using MalaDireta.Context;
using MalaDireta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MalaDireta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        public ClienteController(AppDbContext context, ILogger<ClienteController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("clientes")]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            try
            {
                _logger.LogInformation("================= GET clientes. =================");
                var clientes = _context.Clientes.AsNoTracking().ToList();
                _logger.LogInformation("================= Listando clientes. =================");
                if (!clientes.Any()) { return NotFound("Não há clientes!"); }
                return Ok(clientes);
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                                               "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpGet("{id:int}", Name = "ObterCliente")]
        public ActionResult<Cliente> GetCliente(int id)
        {
            try
            {
                _logger.LogInformation($"================= GET ObterCliente = {id}. =================");
                var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteId == id);
                
                if (cliente != null)  { _logger.LogInformation($"================= Obtido o cliente = {cliente.Nome} ================="); } 
                else  { return NotFound("Não encontrado este cliente"); }                
                
                return cliente;
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação");
            }
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            try
            {
                _logger.LogInformation("================= POST cliente =================");
                if (cliente is null) { return BadRequest("Cliente não enviado."); }

                _context.Add(cliente);
                _context.SaveChanges();
                _logger.LogInformation("================= Cliente salvo =================");

                return new CreatedAtRouteResult("ObterCliente",
                    new { id = cliente.ClienteId }, cliente);
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Cliente cliente)
        {
            try
            {
                _logger.LogInformation("================= PUT/cliente. =================");
                if (id != cliente.ClienteId) { return BadRequest($"Cliente não encotrado com este id={id}"); }

                _context.Entry(cliente).State = EntityState.Modified;
                _context.SaveChanges();
                _logger.LogInformation($"================= Cliente alterado.{DateTime.Now} =================");

                return Ok(cliente);
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }

        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _logger.LogInformation("================= Delete cliente =================");
                
                var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteId == id);
                if (cliente == null) { return NotFound($"Não foi encontrado o cliente com id={id}!"); }

                _context.Clientes.Remove(cliente);
                _context.SaveChanges();

                _logger.LogInformation($"================= Sucesso {DateTime.Now} =================");

                return Ok(cliente);
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }
    }
}
