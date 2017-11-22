using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R34.ConsolidateDuplicateConditionalFragments.depois
{
    class Produto
    {
        private const decimal FATOR_DESCONTO_PROMOCIONAL = 0.95m;
        private const decimal FATOR_DESCONTO_NORMAL = 0.98m;
        readonly decimal preco;
        public decimal Preco => preco;

        readonly decimal precoFinal;
        public decimal PrecoFinal => precoFinal;

        readonly bool ehVendaPromocional;
        public bool EhVendaPromocional => ehVendaPromocional;

        public Produto(decimal preco, bool ehVendaPromocional)
        {
            this.preco = preco;
            this.ehVendaPromocional = ehVendaPromocional;

            if (ehVendaPromocional)
            {
                this.precoFinal = preco * FATOR_DESCONTO_PROMOCIONAL;
            }
            else
            {
                this.precoFinal = preco * FATOR_DESCONTO_NORMAL;
            }
            Catalogo.IncluirProduto(this);
            GerenciadorDeEmail.EnviarEmailDeNovoProduto(this);
        }
    }

    class GerenciadorDeEmail
    {
        public static void EnviarEmailDeNovoProduto(Produto produto)
        {
            //Aqui vai o código para enviar
            //email de lançamento de novo produto...
        }
    }

    class Catalogo
    {
        public static void IncluirProduto(Produto produto)
        {
            //Aqui vai o código para criar novo produto...
        }
    }

}
