using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R40.RenameMethod.antes
{
    class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            System.Console.WriteLine($"Área: {GetValor(altura, largura)}");
        }

        private static double GetValor(double altura, double largura)
        {
            return altura * largura;
        }
    }
}
