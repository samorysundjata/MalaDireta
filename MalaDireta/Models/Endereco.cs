using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalaDireta.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        private int _id;
        private string _logradouro;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _cep;

        public Endereco()
        {

        }

        public Endereco(int id, string logradouro, string cidade, string estado, string cep, string bairro)
        {
            _id = id;
            _logradouro = logradouro;
            _cidade = cidade;
            _estado = estado;
            _cep = cep;
            _bairro = bairro;
        }

        [Key]
        public int EnderecoId { get; set; }

        [Required] 
        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        [Required]
        public string Cidade { get; set; }
        
        [Required]
        public string Bairro { get; set; }

        [Required] //Passar para um enum no futuro?
        public string Estado { get; set; }

        [Required]
        public string CEP { get; set; }

        //Colocar validações aqui.
        //Testar CEP
        //Testar UF
    }
}
