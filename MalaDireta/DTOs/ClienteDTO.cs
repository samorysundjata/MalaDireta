namespace MalaDireta.DTOs
{
    public class ClienteDTO
    {
        //Criar validações aqui ou na classe?
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public int EnderecoId { get; set; }
    }
}
