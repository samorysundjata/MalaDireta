

namespace MalaDireta.Services
{
    public class ViaCepClient : IViaCepClient
    {
        private const string _baseUrl = "https://viacep.com.br";

        private readonly HttpClient _httpClient;

        public ViaCepClient()
        {
            //_httpClient = new HttpClientFactory.Create();

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl)
            };

        }

        public ViaCepClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public ViaCepResult Search(string zipCode)
        {
            return SearchAsync(zipCode, CancellationToken.None).Result;
        }

        public IEnumerable<ViaCepResult> Search(string stateInitials, string city, string address)
        {
            return SearchAsync(stateInitials, city, address, CancellationToken.None).Result;
        }

        public async Task<ViaCepResult> SearchAsync(
            string zipCode,
            CancellationToken cancellationToken
        )
        {
            var response = await _httpClient
                .GetAsync($"/ws/{zipCode}/json", cancellationToken)
                .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content
                .ReadAsAsync<ViaCepResult>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<IEnumerable<ViaCepResult>> SearchAsync(
            string stateInitials,
            string city,
            string address,
            CancellationToken cancellationToken
        )
        {
            var response = await _httpClient
                .GetAsync($"/ws/{stateInitials}/{city}/{address}/json", cancellationToken)
                .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content
                .ReadAsAsync<List<ViaCepResult>>(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
