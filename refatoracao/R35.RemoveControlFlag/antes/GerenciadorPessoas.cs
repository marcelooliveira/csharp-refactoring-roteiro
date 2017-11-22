using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R35.RemoveControlFlag.antes
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
            bool encontrouPessoa = false;
            foreach (var person in pessoas)
            {
                if (person.Equals("Diego"))
                {
                    EnviarAlerta();
                    encontrouPessoa = true;
                }
                if (person.Equals("João"))
                {
                    EnviarAlerta();
                    encontrouPessoa = true;
                }
            }
            return encontrouPessoa;
        }

        private static void EnviarAlerta()
        {
            //código para enviar um alerta
        }
    }

}
