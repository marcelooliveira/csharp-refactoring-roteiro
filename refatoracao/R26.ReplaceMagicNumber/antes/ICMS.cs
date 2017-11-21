using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R26.ReplaceMagicNumber.antes
{
    class ICMS
    {
        public static decimal CalcularValor(decimal aliquota, string uf)
        {
            if (uf == "SP")
            {
                return aliquota * 0.18m;
            }
            return aliquota * 0.15m;
        }
    }
}
