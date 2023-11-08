using MalaDireta.Context;
using MalaDireta.Models;
using MalaDireta.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MalaDireta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IViaCepClient _cepClient;
        private readonly ILogger _logger;

        public EnderecoController(AppDbContext context, IViaCepClient cepClient, ILogger<EnderecoController> logger)
        {
            _context = context;
            _cepClient = cepClient;
            _logger = logger;
        }

        [HttpGet("enderecos")]
        public ActionResult<IEnumerable<Endereco>> GetEnderecos()
        {
            try
            {
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");
                var enderecos = _context.Enderecoes.ToList();
                if (!enderecos.Any()) { return NotFound("Endereços não encontrados"); }                
                return (enderecos);
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                                               "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpGet("{id:int}", Name = "ObterEndereco")]
        public ActionResult<Endereco> GetEndereco(int id)
        {
            try
            {
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");
                var endereco = _context.Enderecoes.FirstOrDefault(e => e.EnderecoId == id);
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");
                if (endereco is null) { return NotFound("Endereço não encontrado"); }
                return endereco;
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }

        [HttpPost]
        public ActionResult Post(Endereco endereco)
        {
            try
            {
                _logger.LogInformation($"================= {DateTime.Now} => POST endereco  =================");
                if (endereco is null) { return BadRequest("O endereço é nulo!"); }

                _context.Add(endereco);
                _context.SaveChanges();

                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");
                return new CreatedAtRouteResult("ObterEndereco",
                    new { id = endereco.EnderecoId }, endereco);                
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Endereco endereco)
        {
            try
            {
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");
                if (id != endereco.EnderecoId) { return BadRequest($"Endereço não encontrado com este id={id}"); }

                _context.Entry(endereco).State = EntityState.Modified;
                _context.SaveChanges();
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");

                return Ok(endereco);
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
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");
                var endereco = _context.Enderecoes.FirstOrDefault(e => e.EnderecoId == id);
                if (endereco is null) { return NotFound($"Endereco com id={id} não encontrado!"); }

                _context.Enderecoes.Remove(endereco);
                _context.SaveChanges();

                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");

                return Ok(endereco);
            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }

        [HttpGet("buscaendereco")]
        public ActionResult<Endereco> GetCep(string cep)
        {
            try
            {
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");
                var retornoCep = _cepClient.Search(cep);

                Endereco endereco = new()
                {
                    Logradouro = retornoCep.Logradouro.ToString() + ' ' + retornoCep.Complemento.ToString(),
                    Cidade = retornoCep.Cidade.ToString() + ' ' + retornoCep.UF.ToString()
                };
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");

                return endereco;

            }
            catch (Exception)
            {
                _logger.LogInformation($"================= {DateTime.Now} => Exceção aqui  =================");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação!");
            }
        }

        [HttpGet("buscacep")]
        public ActionResult<string> GetEnderecoCep(string endereco)
        {
            try
            {
                _logger.LogInformation($"================= {DateTime.Now} => Informação aqui  =================");
                var cep = _cepClient.Search(endereco);
                return cep.ZipCode.ToString();
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
