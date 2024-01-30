namespace MalaDireta.Services
{
    public class ViaCepClient : IViaCepClient
    {
        private readonly HttpClient _httpClient;

        private readonly IConfiguration _configuration;

        public ViaCepClient()
        {
        }

        public ViaCepClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public ViaCepClient(IConfiguration configuration)
        {
            _configuration = configuration;

            string sUri = _configuration["URICep:uri"];

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(sUri)
            };
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
