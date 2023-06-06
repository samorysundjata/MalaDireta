using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalaDireta.Models
{
    [Table("Enderecoes")]
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required] //Será que tem que decompor para número e complemento?
        public string Logradouro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required] //Modificado para int aqui
        public int CEP { get; set; }
    }
}
