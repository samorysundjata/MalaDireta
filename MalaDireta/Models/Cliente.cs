using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalaDireta.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key] //Mudar no futuro para ClienteId
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }
    }
}
