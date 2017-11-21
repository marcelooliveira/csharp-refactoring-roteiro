using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R26.ReplaceMagicNumber.antes
{
    class ICMS
    {
        public decimal ValorICMS(decimal valor)
        {
            return valor * 0.18m;
        }
    }
}
