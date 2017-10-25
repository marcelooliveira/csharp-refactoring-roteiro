using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R04.InlineTemp.antes
{
    class CalculadoraDePrecos
    {
        bool TemDesconto(Pedido pedido)
        {
            decimal valorProdutos = pedido.ValorProdutos();
            return (valorProdutos > 1000);
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
