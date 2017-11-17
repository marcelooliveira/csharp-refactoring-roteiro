using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R36.ReplaceNestedConditional.depois
{
    class Auxilio
    {
        private bool ehFalecido;
        private bool ehSeparado;
        private bool ehAposentado;

        public double GetPagamento()
        {
            if (ehFalecido)
            {
                return ValorFalecido();
            }
            if (ehSeparado)
            {
                return ValorSeparado();
            }
            if (ehAposentado)
            {
                return ValorAposentado();
            }
            return ValorNormal();
        }

        private double ValorNormal()
        {
            throw new NotImplementedException();
        }

        private double ValorAposentado()
        {
            throw new NotImplementedException();
        }

        private double ValorSeparado()
        {
            throw new NotImplementedException();
        }

        private double ValorFalecido()
        {
            throw new NotImplementedException();
        }
    }
}
