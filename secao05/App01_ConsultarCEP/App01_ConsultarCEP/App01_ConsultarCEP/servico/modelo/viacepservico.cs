using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.servico.modelo;
using  Newtonsoft.Json;

namespace App01_ConsultarCEP.servico.modelo
{
    public class ViaCepServico
    {
        private static string _enderecoURL = "http://viacep.com.br/ws/{0}/json";

        public static Endereco BuscarEnderecoViaCEP(string pCep)
        {
            var xNovoEnderecoURL = string.Format(_enderecoURL, pCep);

            var xWc = new WebClient();
            var xConteudo = xWc.DownloadString(xNovoEnderecoURL);

            return JsonConvert.DeserializeObject<Endereco>(xConteudo);

        }
    }
}
