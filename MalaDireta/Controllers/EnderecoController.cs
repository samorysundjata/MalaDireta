using MalaDireta.Context;
using MalaDireta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MalaDireta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecoController : Controller
    {
        private readonly AppDbContext _context;
        //private readonly ILogger _logger;

        public EnderecoController(AppDbContext context/*, ILogger logger*/)
        {
            _context = context;
            //_logger = logger;
        }

        [HttpGet("enderecos")]
        public ActionResult<IEnumerable<Endereco>> GetEnderecos() 
        {
            try
            {
                var enderecos = _context.Clientes.ToList();
                if (!enderecos.Any()) { return NotFound("Endereços não encontrados"); }
                //Verificar se o retorno precisa ser Json mesmo.
                return Json(enderecos);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                               "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpGet("{id:int}", Name ="ObterEndereco")]
        public ActionResult<Endereco> GetEndereco(int id) 
        {
            try
            {
                var endereco = _context.Enderecoes.FirstOrDefault(e => e.EnderecoId == id);
                if (endereco is null) { return NotFound("Endereço não encontrado"); }
                return endereco;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }

        [HttpPost]
        public  ActionResult Post(Endereco endereco) 
        {
            try
            {
                if (endereco is null) { return BadRequest("O endereço é nulo!"); }

                _context.Add(endereco);
                _context.SaveChanges();

                return new CreatedAtRouteResult("ObterEndereco", 
                    new { id = endereco.EnderecoId }, endereco);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Endereco endereco) 
        {
            try
            {
                if (id != endereco.EnderecoId) { return BadRequest($"Endereço não encontrado com este id={id}"); }

                _context.Entry(endereco).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok(endereco);
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
                var endereco = _context.Enderecoes.FirstOrDefault(e => e.EnderecoId == id);
                if(endereco is null) { return NotFound($"Endereco com id={id} não encontrado!"); }

                _context.Enderecoes.Remove(endereco);
                _context.SaveChanges();

                return Ok(endereco);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }
    }
}
