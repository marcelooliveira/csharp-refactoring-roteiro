using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R21.ChangeReferenceToValue.antes
{
    class Programa
    {
        public CartaoDeCredito GetMasterCard()
        {
            return CartaoDeCredito.Create("MC");
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

        private CartaoDeCredito(string nome)
        {
            this.nome = nome;
        }

        public static CartaoDeCredito Create(string nome)
        {
            return new CartaoDeCredito(nome);
        }

        public decimal ValorComTaxa(decimal valor)
        {
            return valor * (1.0M + Taxa);
        }
    }

}
