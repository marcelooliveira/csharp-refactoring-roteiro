using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R37.ReplaceConditionalWithPolymorphism.depois
{
    public abstract class Robo
    {
        private readonly double velocidadePadrao = 12.43;
        private readonly double capacidadeDeCarga = 1.67;
        protected readonly double potencia;

        private const int R2D2 = 0;
        private const int WALLY = 1;
        private const int BAYMAX = 2;

        public double GetCapacidadeDeCarga()
        {
            return capacidadeDeCarga;
        }

        public double GetVelocidadePadrao()
        {
            return GetVelocidadePadrao(1);
        }

        public double GetVelocidadePadrao(double potencia)
        {
            return velocidadePadrao * potencia;
        }

        public abstract double GetVelocidade();
    }

    public class R2D2 : Robo
    {
        public override double GetVelocidade()
        {
            return GetVelocidadePadrao();
        }
    }

    public class Wally : Robo
    {
        private readonly int numeroDeBlocos = 34;
        public override double GetVelocidade()
        {
            return GetVelocidadePadrao() - GetCapacidadeDeCarga() * numeroDeBlocos;
        }
    }

    public class Baymax : Robo
    {
        private readonly bool comArmadura = false;
        public override double GetVelocidade()
        {
            return comArmadura ? 0 : GetVelocidadePadrao(potencia);
        }
    }
}
