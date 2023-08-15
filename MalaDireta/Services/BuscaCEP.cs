using MalaDireta.Models;
using WSCorreios;
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

                return Task.Run(() => { string valor = cep; });
                
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }

        public string ConsultaEndereco(string endereco)
        {
            try
            {
                var cep = "123456789";

                return cep;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
