using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using  App01_ConsultarCEP.servico.modelo;
using App01_ConsultarCEP.servico;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //todo - Lógica do programa

            var xCep = CEP.Text.Trim();
            //todo - Validações
            var xEnd = ViaCepServico.BuscarEnderecoViaCEP(xCep);
            RESULTADO.Text = $"Endereço: {xEnd.Logradouro} - {xEnd.Bairro} - {xEnd.Localidade}, {xEnd.UF}";
        }
    }
}
