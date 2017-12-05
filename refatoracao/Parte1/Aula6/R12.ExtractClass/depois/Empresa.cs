using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R12.ExtractClass.depois
{
    class Empresa
    {
        private readonly Endereco enderecoEntrega;
        private readonly Endereco enderecoComercial;

        public Empresa(string razaoSocial, string cNPJ, string endEntregaLogradouro, string endEntregaNumero, string endEntregaComplemento, string endEntregaBairro, string endEntregaCEP, string endEntregaMunicipio, string endEntregaUF, string endComercialLogradouro, string endComercialNumero, string endComercialComplemento, string endComercialBairro, string endComercialCEP, string endComercialMunicipio, string endComercialUF)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;

            this.enderecoEntrega = new Endereco(endEntregaLogradouro, endEntregaNumero, endEntregaComplemento, endEntregaBairro, endEntregaCEP, endEntregaMunicipio, endEntregaUF);
            this.enderecoComercial = new Endereco(endComercialLogradouro, endComercialNumero, endComercialComplemento, endComercialBairro, endComercialCEP, endComercialMunicipio, endComercialUF);
        }

        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }

        public string GetTextoEnderecoComercial()
        {
            return $"Endereço Comercial: " + enderecoComercial.GetTexto();
        }

        public string GetTextoEnderecoEntrega()
        {
            return "Endereço Entrega: " + enderecoEntrega.GetTexto();
        }

        public void UpdateEnderecoEntrega(string logradouro, string numero, string complemento, string bairro, string cEP, string municipio, string uF)
        {
            enderecoEntrega.Update(logradouro, numero, complemento, bairro, cEP, municipio, uF);
        }

        public void UpdateEnderecoComercial(string logradouro, string numero, string complemento, string bairro, string cEP, string municipio, string uF)
        {
            enderecoEntrega.Update(logradouro, numero, complemento, bairro, cEP, municipio, uF);
        }
    }

    class Endereco
    {
        public Endereco(string logradouro, string numero, string complemento, string bairro, string cEP, string municipio, string uF)
        {
            Update(logradouro, numero, complemento, bairro, cEP, municipio, uF);
        }

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Municipio { get; private set; }
        public string UF { get; private set; }

        public string GetTexto()
        {
            return $"{Logradouro} {Numero} {Complemento} - {Bairro} - CEP {CEP} - {Municipio} - {UF}";
        }

        public void Update(string logradouro, string numero, string complemento, string bairro, string cEP, string municipio, string uF)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cEP;
            Municipio = municipio;
            UF = uF;
        }
    }
}
