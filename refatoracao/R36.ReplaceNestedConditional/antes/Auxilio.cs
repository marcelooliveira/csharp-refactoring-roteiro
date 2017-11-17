using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R36.ReplaceNestedConditional.antes
{
    class Auxilio
    {
        private bool ehFalecido;
        private bool ehSeparado;
        private bool ehAposentado;

        public double GetPagamento()
        {
            double result;

            if (ehFalecido)
            {
                result = ValorFalecido();
            }
            else
            {
                if (ehSeparado)
                {
                    result = ValorSeparado();
                }
                else
                {
                    if (ehAposentado)
                    {
                        result = ValorAposentado();
                    }
                    else
                    {
                        result = ValorNormal();
                    }
                }
            }

            return result;
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
