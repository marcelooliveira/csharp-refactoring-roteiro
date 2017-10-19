using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R08.ReplaceMethodWithMethodObject.antes
{
    class Produto
    {
        private double precoBase;
        private double acrescimo;
        private double desconto;

        public double PrecoBase { get => precoBase; }
        public double Acrescimo { get => acrescimo; }
        public double Desconto { get => desconto; }

        public Produto(double precoBase, double acrescimo, double desconto)
        {
            this.precoBase = precoBase;
            this.acrescimo = acrescimo;
            this.desconto = desconto;

            var preco = Preco(precoBase, acrescimo, desconto);

            Console.WriteLine($"ANTES: O preço é {preco}");
        }

        double Preco(double precoBase, double acrescimo, double desconto)
        {
            //aqui viria um cálculo muito mais complicado do que esse...
            return precoBase + acrescimo - desconto;
        }
    }
}
