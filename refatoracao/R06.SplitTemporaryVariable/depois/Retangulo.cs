using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R06.SplitTemporaryVariable.depois
{
    class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            double perimetro = 2 * (altura + largura);
            System.Console.WriteLine($"Perímetro: {perimetro}");
            double area = altura * largura;
            System.Console.WriteLine($"Área: {area}");
        }
    }
}
