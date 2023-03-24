using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
       /* private readonly EnderecoClient _restClient;
        public EnderecoController(EnderecoClient restclient)
        {
            _restClient = restclient;
        }*/
       
        [HttpGet("/logradouro")]
        public string Endereco(string cep)
        {
            var end = new EnderecoClient();
            var endereco = end.EnderecoGet(cep);
            return endereco.Logradouro;
            

        }

        [HttpGet("/Endereco")]
        public string EnderecoCompleto(string cep)
        {
            //var end = new EnderecoClient();
            var requisisao = new EnderecoClient();
            var retorno = requisisao.EnderecoGet(cep);

            return retorno.ToString();

        }
    }
}
