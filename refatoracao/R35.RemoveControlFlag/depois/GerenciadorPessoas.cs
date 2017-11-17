using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R35.RemoveControlFlag.depois
{
    class Solution
    {
        public Solution()
        {
            IEnumerable<string> pessoas = new List<string>();
            ChecarSeguranca(pessoas);
        }

        private void ChecarSeguranca(IEnumerable<string> pessoas)
        {
            string encontrouPessoa = string.Empty;
            encontrouPessoa = EncontrarPessoa(pessoas);
            var p = encontrouPessoa;
        }

        private static string EncontrarPessoa(IEnumerable<string> pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                if (pessoa.Equals("Diego"))
                {
                    EnviarAlerta();
                    return pessoa;
                }
                if (pessoa.Equals("João"))
                {
                    EnviarAlerta();
                    return pessoa;
                }
            }

            return string.Empty;
        }

        private static void EnviarAlerta()
        {
            var blabla = 0;
        }
    }
}
