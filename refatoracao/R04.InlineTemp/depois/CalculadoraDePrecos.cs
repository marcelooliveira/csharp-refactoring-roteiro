using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R04.InlineTemp.depois
{
    class CalculadoraDePrecos
    {
        bool TemDesconto(Pedido pedido)
        {
            return (pedido.ValorProdutos() > 1000);
        }
    }

    class Pedido
    {
        private decimal valorProdutos;

        public decimal ValorProdutos()
        {
            return valorProdutos;
        }
    }
}
