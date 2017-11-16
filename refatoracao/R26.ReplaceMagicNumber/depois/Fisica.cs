using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R26.ReplaceMagicNumber.depois
{
    class Fisica
    {
        private const double ACELERACAO_GRAVIDADE = 9.81;

        public double EnergiaPotencial(double massa, double altura)
        {
            return massa * altura * ACELERACAO_GRAVIDADE;
        }
    }
}
