using System.Runtime.ConstrainedExecution;
using Exception = System.Exception;

namespace MalaDireta.Services
{
    public class BuscaCEP : IBuscaCep
    {
        public BuscaCEP()
        {

        }

        public Task ConsultaCEP(string cep)
        {
            try
            {
                return Task.Run(() => { _ = cep; });
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Task ConsultaEndereco(string endereco)
        {
            try
            {
                return Task.Run(() => { _ = endereco; });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
