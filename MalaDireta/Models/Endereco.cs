using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalaDireta.Models
{
    [Table("Enderecoes")]
    public class Endereco
    {
        private readonly int _id;
        private readonly string _logradouro;
        private readonly string _cidade;
        private readonly string _estado;
        private readonly int _cep;

        public Endereco()
        {

        }

        public Endereco(int id, string logradouro, string cidade, string estado, int cep)
        {
            _id = id;
            _logradouro = logradouro;
            _cidade = cidade;
            _estado = estado;
            _cep = cep;
        }

        [Key]
        public int EnderecoId { get; set; }

        [Required] //Decompor para endereço, número e complemento.
        public string Logradouro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required] //Passar para um enum no futuro?
        public string Estado { get; set; }

        [Required]
        public int CEP { get; set; }

        //Colocar validações aqui.
    }
}
