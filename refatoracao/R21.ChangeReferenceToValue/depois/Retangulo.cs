using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R21.ChangeReferenceToValue.depois
{
    class Retangulo
    {
        private readonly Linha linhaSuperior;
        private readonly Linha linhaInferior;
        private readonly Linha linhaEsquerda;
        private readonly Linha linhaDireita;

        internal Linha LinhaSuperior => linhaSuperior;
        internal Linha LinhaInferior => linhaInferior;
        internal Linha LinhaEsquerda => linhaEsquerda;
        internal Linha LinhaDireita => linhaDireita;

        public Retangulo(int x1, int y1, int x2, int y2)
        {
            linhaSuperior = new Linha(x1, y1, x2, y1);
            linhaInferior = new Linha(x1, y2, x2, y2);
            linhaEsquerda = new Linha(x1, y1, x1, y2);
            linhaDireita = new Linha(x2, y1, x2, y2);
        }
    }

    class Linha
    {
        private readonly int x1;
        private readonly int y1;
        private readonly int x2;
        private readonly int y2;

        public Linha(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public int X1
        {
            get { return x1; }
        }

        public int Y1
        {
            get { return y1; }
        }

        public int X2
        {
            get { return x2; }
        }

        public int Y2
        {
            get { return y2; }
        }

        public override bool Equals(object obj)
        {
            var that = obj as Linha;
            if (obj == null)
            {
                return false;
            }

            return (that.x1.Equals(this.x1)
                    && that.y1.Equals(this.y1)
                    && that.x2.Equals(this.x2)
                    && that.y2.Equals(this.y2))
                    ||
                    (that.x2.Equals(this.x1)
                    && that.y2.Equals(this.y1)
                    && that.x1.Equals(this.x2)
                    && that.y1.Equals(this.y2));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x1.GetHashCode();
                hash = hash * 23 + y1.GetHashCode();
                hash = hash * 23 + x2.GetHashCode();
                hash = hash * 23 + y2.GetHashCode();
                return hash;
            }
        }
    }
}
