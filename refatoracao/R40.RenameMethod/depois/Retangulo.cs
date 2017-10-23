using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R40.RenameMethod.depois
{
    class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            System.Console.WriteLine($"Área: {GetArea(altura, largura)}");
        }

        private static double GetArea(double altura, double largura)
        {
            return altura * largura;
        }
    }
}
