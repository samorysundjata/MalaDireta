using System.ComponentModel.DataAnnotations;

namespace MalaDireta.Models
{

    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }
    }
}
