namespace MalaDireta.Services
{
    public interface IBuscaCep
    {
        public Task ConsultaCEP(string cep);

        public string ConsultaEndereco(string endereco);
    }
}
