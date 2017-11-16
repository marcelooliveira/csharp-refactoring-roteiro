using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R18.SelfEncapsulateField.depois
{
    class FaixaDeAcidezIdeal
    {
        private double phMinimo, phMaximo;

        public double PhMinimo
        {
            get
            {
                return phMinimo;
            }
        }

        public double PhMaximo
        {
            get
            {
                return phMaximo;
            }
        }

        public FaixaDeAcidezIdeal(double phMinimo, double phMaximo)
        {
            this.phMinimo = phMinimo;
            this.phMaximo = phMaximo;
        }

        bool Inclui(double ph)
        {
            return ph >= PhMinimo && ph <= PhMaximo;
        }
    }
}
