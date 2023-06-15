using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalaDireta.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        //Criar validações aqui.

        private int id;
        private string nome;
        private string telefone;
        private string email;

        public Cliente()
        {
        }

        public Cliente(int _id, string _nome, string _telefone, string _email)
        {
            this.id = _id;
            this.nome = _nome;
            this.telefone = _telefone;
            this.email = _email;
        }

        [Key] //Mudar no futuro para ClienteId
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }
    }
}
