using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalaDireta.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        //Criar validações aqui.

        private readonly int id;
        private readonly string nome;
        private string telefone;
        private string email;
        //private Endereco endereco;

        public Cliente()
        {
        }

        public Cliente(int _id, string _nome, string _telefone, string _email/*, Endereco _endereco*/)
        {
            this.id = _id;
            this.nome = _nome;
            this.telefone = _telefone;
            this.email = _email;
            //this.endereco = _endereco;
        }

        [Key]
        public int ClienteId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }

        //[Required]
        //public ICollection<Endereco> Locais { get; set; }
    }
}
