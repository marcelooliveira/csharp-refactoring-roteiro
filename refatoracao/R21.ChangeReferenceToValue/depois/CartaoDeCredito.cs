using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R21.ChangeReferenceToValue.depois
{
    class Programa
    {
        public bool TesteMasterCard()
        {
            return new CartaoDeCredito("MC").Equals(new CartaoDeCredito("MC"));
        }
    }

    class CartaoDeCredito
    {
        private readonly string nome;
        private decimal taxa;

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public decimal Taxa
        {
            get { return taxa; }
            set
            {
                taxa = value;
            }
        }

        public CartaoDeCredito(string nome)
        {
            this.nome = nome;
        }

        public decimal ValorComTaxa(decimal valor)
        {
            return valor * (1.0M + taxa);
        }

        public override bool Equals(object obj)
        {
            var outro = obj as CartaoDeCredito;
            if (outro == null)
            {
                return false;
            }
            return this.nome.Equals(outro.nome);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }

}
