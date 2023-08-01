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
                    var wendereco = (await ws.consultaCEPAsync(cep.Trim())).@return;


                    Endereco endereco = new Endereco();

                    endereco.Logradouro = wendereco.end;
                    endereco.Cidade = wendereco.cidade;
                    endereco.CEP = Convert.ToInt32(cep);



                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
    }
}
