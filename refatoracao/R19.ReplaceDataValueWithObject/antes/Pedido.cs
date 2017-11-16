using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R19.ReplaceDataValueWithObject.antes
{
    class Pedido
    {
        public readonly string cliente;
        public string Cliente { get; }

        public Pedido(string cliente)
        {
            this.cliente = cliente;
        }
        
        private static int QuantidadeDePedidosDe(IEnumerable<Pedido> pedidos, string cliente)
        {
            return pedidos
                .Count(p => 
                    p.Cliente.Equals(cliente, 
                        StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
