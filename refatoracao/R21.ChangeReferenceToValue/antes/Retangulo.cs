using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R21.ChangeReferenceToValue.antes
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
            linhaSuperior = Linha.GetOrCreate(x1, y1, x2, y1);
            linhaInferior = Linha.GetOrCreate(x1, y2, x2, y2);
            linhaEsquerda = Linha.GetOrCreate(x1, y1, x1, y2);
            linhaDireita = Linha.GetOrCreate(x2, y1, x2, y2);
        }
    }

    class Linha
    {
        static HashSet<Linha> linhas = new HashSet<Linha>();

        static Linha()
        {
            linhas = new HashSet<Linha>();
        }

        private int x1;
        private int y1;
        private int x2;
        private int y2;

        private Linha(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public static Linha GetOrCreate(int x1, int y1, int x2, int y2)
        {
            Linha linha = linhas.SingleOrDefault(l => l.Equals(new Linha(x1, y1, x2, y2)));
            if (linha == null)
            {
                linhas.Add(linha);
            }
            return linha;
        }

        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
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
