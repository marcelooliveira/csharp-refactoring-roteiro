using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R37.ReplaceConditionalWithPolymorphism.antes
{
    public class Robo
    {
        private readonly int tipo;
        private readonly double velocidadePadrao = 12.43;
        private readonly double capacidadeDeCarga = 1.67;
        private readonly int numeroDeBlocos = 34;
        private readonly bool comArmadura = false;
        private readonly double potencia;

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

        public double GetVelocidade()
        {
            switch (tipo)
            {
                case R2D2:
                    return GetVelocidadePadrao();
                case WALLY:
                    return GetVelocidadePadrao() - GetCapacidadeDeCarga() * numeroDeBlocos;
                case BAYMAX:
                    return comArmadura ? 0 : GetVelocidadePadrao(potencia);
                default:
                    throw new Exception("Tipo não identificado");
            }
        }
    }
}
