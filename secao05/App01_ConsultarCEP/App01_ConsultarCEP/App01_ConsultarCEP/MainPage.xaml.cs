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

            if (CEPEhVAlido(xCep))
            {
                var xEnd = ViaCepServico.BuscarEnderecoViaCEP(xCep);
                RESULTADO.Text = $"Endereço: {xEnd.Logradouro} - {xEnd.Bairro} - {xEnd.Localidade}, {xEnd.UF}";
            }
            
        }

        private bool CEPEhVAlido(string pCEP)
        {
            var xValido = true;
            if (pCEP.Length != 8)
            {
                DisplayAlert("Erro", "CEP inválido! O CEP deve conter 8 caracteres", "OK");
                xValido = false;
            }
            int xNovoCep = 0;
            if (!int.TryParse(pCEP, out xNovoCep))
            {
                DisplayAlert("Erro", "CEP inválido! O CEP deve ser composto apenas por números", "OK");
                xValido = false;
            }

            return xValido;
        }
    }
}
