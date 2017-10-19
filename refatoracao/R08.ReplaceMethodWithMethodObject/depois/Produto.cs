using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R08.ReplaceMethodWithMethodObject.depois
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

            var preco = new CalculadoraDePrecos(this).Calcular();

            Console.WriteLine($"DEPOIS: O preço é {preco}");
        }
    }

    class CalculadoraDePrecos
    {
        private readonly double precoBase;
        private readonly double acrescimo;
        private readonly double desconto;

        public double PrecoBase { get => precoBase; }
        public double Acrescimo { get => acrescimo; }
        public double Desconto { get => desconto; }

        public CalculadoraDePrecos(Produto produto)
        {
            this.precoBase = produto.PrecoBase;
            this.acrescimo = produto.Acrescimo;
            this.desconto = produto.Desconto;
        }

        public double Calcular()
        {
            //aqui viria um cálculo muito mais complicado do que esse...
            return precoBase + acrescimo - desconto;
        }
    }
}
