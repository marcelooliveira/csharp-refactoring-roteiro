using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R35.RemoveControlFlag.depois
{
    class GerenciadorPessoas
    {
        public GerenciadorPessoas()
        {
            IList<string> pessoas = new List<string>
            {
                "Marcelo",
                "Marcos",
                "Diego",
                "Caio",
                "Marlon"
            };


            var encontrouPessoa = EncontrarPessoaEspecial(pessoas);
        }

        private bool EncontrarPessoaEspecial(IList<string> pessoas)
        {
            IList<string> pessoasEspeciais = GetPessoasEspeciais();
            foreach (var person in pessoas)
            {
                if (pessoasEspeciais.Contains(person))
                {
                    EnviarAlerta();
                    return true;
                }
            }
            return false;
        }

        private static IList<string> GetPessoasEspeciais()
        {
            return new List<string>
            {
                "Diego",
                "João"
            };
        }

        private static void EnviarAlerta()
        {
            //código para enviar um alerta
        }
    }

}
