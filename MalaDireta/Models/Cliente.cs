using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalaDireta.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        //Criar validações aqui.

        private int _id;
        private string _nome;
        private string _telefone;
        private string _email;
        private Endereco _endereco;

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string telefone, string email, Endereco endereco)
        {
            this._id = id;
            this._nome = nome;
            this._telefone = telefone;
            this._email = email;
            this._endereco = endereco;
        }

        [Key]
        public int ClienteId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string? Telefone { get; set; }

        public Email Email { get; set; }

        public Endereco? Endereco { get; set; }
        
    }
}
