using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R54.PullUpMethod.depois
{
    class Programa
    {
        void Main()
        {
            var fabrica = new Fabrica();
            fabrica.Fabricar();
        }
    }

    abstract class Microondas
    {
        protected double altura;
        protected double largura;
        protected double profundidade;

        public Microondas(double altura, double largura, double profundidade)
        {
            this.altura = altura;
            this.largura = largura;
            this.profundidade = profundidade;
        }

        public abstract int GetVoltagem();

        public double GetVolume()
        {
            return altura * largura * profundidade;
        }
    }

    class Microondas110 : Microondas
    {
        public Microondas110(double altura, double largura, double profundidade) : base(altura, largura, profundidade)
        {
        }

        public override int GetVoltagem()
        {
            return 110;
        }
    }

    class Microondas220 : Microondas
    {
        public Microondas220(double altura, double largura, double profundidade) : base(altura, largura, profundidade)
        {
        }

        public override int GetVoltagem()
        {
            return 220;
        }
    }

    class Fabrica
    {
        public void Fabricar()
        {
            var aparelho1 = new Microondas220(28.9, 43.1, 34.1);
            var aparelho2 = new Microondas110(28.9, 43.1, 34.1);

            Fabricar(aparelho1);
            Fabricar(aparelho2);
        }

        public void Fabricar(Microondas microondas)
        {
            //código para fabricar equipamento...
        }
    }
}
