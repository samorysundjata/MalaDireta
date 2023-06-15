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
        //private readonly ILogger _logger;

        public ClienteController(AppDbContext context/*, ILogger logger*/)
        {
            _context = context;
            //_logger = logger;
        }

        [HttpGet("clientes")]
        public ActionResult<IEnumerable<Cliente>> GetClientes() 
        {
            try
            {
                //_logger.LogInformation("Listagem geral de clientes",
                //    DateTime.UtcNow.ToLongTimeString());

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
                //_logger.LogInformation($"Recuperando o cliente pelo id {id}",
                //   DateTime.UtcNow.ToLongTimeString());

                var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
                if (cliente == null) { return NotFound("Não encontrado este cliente");  }
                return cliente;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    "Ocorreu um problema ao tratar a sua solicitação");
            }
        }

        [HttpPost]
        public ActionResult Post(Cliente cliente) 
        {
            try
            {
                //_logger.LogInformation("Inserção de cliente",
                //   DateTime.UtcNow.ToLongTimeString());

                if (cliente is null) { return BadRequest("Cliente não enviado.");  }

                _context.Add(cliente);
                _context.SaveChanges();

                return new CreatedAtRouteResult("ObterCliente", 
                    new { id = cliente.Id }, cliente);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Cliente cliente) 
        {
            try
            {
                if (id != cliente.Id) { return BadRequest($"Cliente não encotrado com este id={id}");  }

                _context.Entry(cliente).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok(cliente);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
            
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) 
        {
            try
            {
                var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
                if (cliente == null) { return NotFound($"Não encontrado o cliente com id={id}!");  }

                _context.Clientes.Remove(cliente);
                _context.SaveChanges();

                return Ok(cliente);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }
    }
}
