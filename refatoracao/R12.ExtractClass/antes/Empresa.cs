using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R12.ExtractClass.antes
{
    class Empresa
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Municipio { get; private set; }
        public string UF { get; private set; }
        public string GetEndereco()
        {
            return $"{Logradouro} {Numero} {Complemento} - {Bairro} - CEP {CEP} - {Municipio} - {UF}";
        }
    }
}
