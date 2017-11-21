using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R26.ReplaceMagicNumber.depois
{
    class ICMS
    {
        private const decimal ICMS_SP_PARA_SP = 0.18m;
        private const decimal ICMS_PADRAO = 0.15m;
        private const string SAO_PAULO = "SP";

        public static decimal CalcularValor(decimal aliquota, string uf)
        {
            if (uf == SAO_PAULO)
            {
                return aliquota * ICMS_SP_PARA_SP;
            }
            return aliquota * ICMS_PADRAO;
        }
    }
}
