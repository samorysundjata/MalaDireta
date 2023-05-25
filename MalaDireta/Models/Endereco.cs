using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalaDireta.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key] //Mudar no futuro para ProdutoId
        public int Id { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string CEP { get; set; }
    }
}
