using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R26.ReplaceMagicNumber.depois
{
    class ICMS
    {
        private const decimal ICMS_SP_PARA_SP = 0.18m;

        public decimal ValorICMSSPParaSP(decimal valor)
        {
            return valor * ICMS_SP_PARA_SP;
        }
    }
}
