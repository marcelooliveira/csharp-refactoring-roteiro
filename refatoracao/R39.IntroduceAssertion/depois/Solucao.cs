using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R39.IntroduceAssertion.depois
{
    class Solucao
    {
        private decimal limiteDespesa;

        public decimal DESPESA_NULA { get; private set; }

        decimal GetLimiteDespesa()
        {
            var projetoPrimario = new Projeto();

            Assert.IsTrue(limiteDespesa != DESPESA_NULA || projetoPrimario != null);

            return (limiteDespesa != DESPESA_NULA) ?
              limiteDespesa :
              projetoPrimario.GetLimiteDespesa();
        }
    }

    internal class Projeto
    {
        public Projeto()
        {
        }

        internal decimal GetLimiteDespesa()
        {
            throw new NotImplementedException();
        }
    }

    internal class Assert
    {
        public Assert()
        {
        }

        internal static bool IsTrue(object p)
        {
            throw new NotImplementedException();
        }
    }
}
