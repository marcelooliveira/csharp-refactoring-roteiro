using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R18.SelfEncapsulateField.antes
{
    class FaixaDeAcidezIdeal
    {
        private double phMinimo, phMaximo;

        public FaixaDeAcidezIdeal(double phMinimo, double phMaximo)
        {
            this.phMinimo = phMinimo;
            this.phMaximo = phMaximo;
        }

        bool Inclui(double ph)
        {
            return ph >= phMinimo && ph <= phMaximo;
        }
    }
}
