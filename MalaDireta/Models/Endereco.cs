using System.ComponentModel.DataAnnotations;

namespace MalaDireta.Models
{
    public class Endereco
    {
        [Key]
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
