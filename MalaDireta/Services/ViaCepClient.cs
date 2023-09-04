

namespace MalaDireta.Services
{
    public class ViaCepClient : IViaCepClient
    {
        private const string _baseUrl = "https://viacep.com.br";

        private readonly HttpClient _httpClient;

        public ViaCepClient()
        {
            //_httpClient = new HttpClientFactory.Create();

            _httpClient = new HttpClient();

        }

        public ViaCepResult Search(string zipCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ViaCepResult> Search(string stateInitials, string city, string address)
        {
            throw new NotImplementedException();
        }

        public Task<ViaCepResult> SearchAsync(string zipCode, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ViaCepResult>> SearchAsync(string stateInitials, string city, string address, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
