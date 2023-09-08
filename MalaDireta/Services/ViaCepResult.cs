using Newtonsoft.Json;

namespace MalaDireta.Services
{
    public sealed class ViaCepResult
    {
        [JsonProperty("cep")]
        public string ZipCode { get; set; }

        [JsonProperty("logradouro")] 
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Cidade { get; set; }

        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("unidade")]
        public string Unit { get; set; }

        [JsonProperty("ibge")]
        public int IBGECode { get; set; }

        [JsonProperty("gia")]
        public int? GIACode { get; set; }
    }
}
