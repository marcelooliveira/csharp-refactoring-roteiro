using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R39.IntroduceAssertion.antes
{
    class Problema
    {
        private double limiteDespesa;

        public double DESPESA_NULA { get; private set; }

        double GetLimiteDespesa()
        {
            // deve ter ou um limite de despesa ou um projeto primário
            return (limiteDespesa != DESPESA_NULA) ?
              limiteDespesa :
              ProjetoPrimario.GetLimiteDespesa();
        }
    }

    internal class ProjetoPrimario
    {
        internal static double GetLimiteDespesa()
        {
            throw new NotImplementedException();
        }
    }

}
