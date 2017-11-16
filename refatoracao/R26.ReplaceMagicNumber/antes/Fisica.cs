using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R26.ReplaceMagicNumber.antes
{
    class Fisica
    {
        public double EnergiaPotencial(double massa, double altura)
        {
            return massa * altura * 9.81;
        }
    }
}
