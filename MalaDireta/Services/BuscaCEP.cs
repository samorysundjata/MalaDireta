using MalaDireta.Models;
using WSCorreios;

namespace MalaDireta.Services
{
    public class BuscaCEP
    {
        public BuscaCEP()
        {

        }

        public async Task ConsultaCEP(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                try
                {
                    var wendereco = (await ws.consultaCEPAsync("24710480")).@return;


                    Endereco endereco = new Endereco();

                    endereco.Logradouro = wendereco.end;                    



                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
    }
}
