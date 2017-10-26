using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R07.RemoveAssignmentsToParameters.depois
{
    class CalculadoraDePrecos
    {
        decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos)
        {
            var result = descontoInicial;
            if (descontoInicial > 50M)
            {
                result = 50M;
            }
            if (quantidade > 100)
            {
                result += 15M;
            }
            if (clienteHaQuantosAnos > 4)
            {
                result += 10M;
            }
            return result;
        }
    }
}
