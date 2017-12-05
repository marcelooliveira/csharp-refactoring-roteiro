using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R06.SplitTemporaryVariable.antes
{
    class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            double temp = 2 * (altura + largura);
            System.Console.WriteLine($"Perímetro: {temp}");
            temp = altura * largura;
            System.Console.WriteLine($"Área: {temp}");
        }
    }
}
