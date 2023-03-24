using RestSharp;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace WebApi.Models
   
{
    public class EnderecoClient
    {
        private readonly RestClient _restClient;

        public EnderecoClient()
        {
            

        }

        public Endereco EnderecoGet(string cep)
        {
            string ViaCepBaseUrl = $"https://viacep.com.br/ws/{cep}/json/";

            var restClient = new RestClient(ViaCepBaseUrl);
            var request = new RestRequest(resource: "");
            var endereco = restClient.Get<Endereco>(request);

            return endereco;
        }


    }
}
