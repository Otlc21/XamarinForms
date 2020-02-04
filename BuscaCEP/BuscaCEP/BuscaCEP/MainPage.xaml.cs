using BuscaCEP.Model;
using BuscaCEP.Service;
using System;
using Xamarin.Forms;

namespace BuscaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = cepEntry.Text;

            Result result = ValidarCEP(cep);
            if (result.Sucess)
            {
                result = BuscaCEPService.BuscarEnderecoPorCEP(cep.Trim(), out Endereco endereco);
                if (result.Sucess)
                    resultadoLabel.Text = endereco.ToString();
                else
                    DisplayAlert("Falha ao Consultar CEP", result.Description, "OK");
            }
            else
            {
                DisplayAlert("Falha ao Consultar CEP", result.Description, "OK");
                cepEntry.Focus();
            }
        }

        private Result ValidarCEP(string cep)
        {
            Result result = new Result();

            if (string.IsNullOrEmpty(cep))
                return new Result("Para pesquisar você deve informe o CEP.");

            if (!int.TryParse(cep, out int cepInt))
                return new Result("Informe apenas números inteiros no CEP.");

            if (cep.Length != 8)
                return new Result("O CEP informado deve possuir 8 digitos.");

            return result;
        }
    }
}
