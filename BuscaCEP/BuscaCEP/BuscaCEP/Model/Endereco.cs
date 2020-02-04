namespace BuscaCEP.Model
{
    public class Endereco
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Unidade { get; set; }
        public string IBGE { get; set; }
        public string GIA { get; set; }

        public override string ToString()
        {
            return "Logradouro: " + Logradouro + "\n" +
                   "Complemento: " + Complemento + "\n" +
                   "Bairro: " + Bairro + "\n" +
                   "Localidade: " + Localidade + "\n" +
                   "UF: " + UF + "\n" +
                   "Unidade: " + Unidade + "\n" +
                   "IBGE: " + IBGE + "\n" +
                   "GIA: " + GIA + "\n";
        }
    }
}
