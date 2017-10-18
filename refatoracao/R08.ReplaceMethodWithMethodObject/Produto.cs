using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R08.ReplaceMethodWithMethodObject
{
    class Produto
    {
        public Produto()
        {
            var preco = Preco();
            Console.WriteLine($"O preço é {preco}");
        }

        double Preco()
        {
            double precoBase = 100.0;
            double acrescimo = 10;
            double desconto = 5;

            return precoBase + acrescimo - desconto;
        }
    }
}
