using BuscaCEP.Model;
using Newtonsoft.Json;
using System;
using System.Net;

namespace BuscaCEP.Service
{
    public class BuscaCEPService
    {
        private static string URL = "https://viacep.com.br/ws/{0}/json/";

        public static Result BuscarEnderecoPorCEP(string cep, out Endereco endereco)
        {
            endereco = null;
            Result result = new Result();
            string resposta = string.Empty;

            try
            {
                WebClient webClient = new WebClient();
                resposta = webClient.DownloadString(string.Format(URL, cep));
            }
            catch (Exception ex)
            {
                return new Result(ex.Message);
            }

            endereco = JsonConvert.DeserializeObject<Endereco>(resposta);
            if (endereco.CEP == null)
                result = new Result("Endereço não encontrado para o CEP: " + cep);

            return result;
        }
    }
}
