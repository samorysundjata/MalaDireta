using WSCorreios;

namespace MalaDireta.Services
{
    public class BuscaCEP
    {
        public BuscaCEP()
        {

        }

        public void ConsultaCEP(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEPAsync(cep);
                   
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
    }
}
