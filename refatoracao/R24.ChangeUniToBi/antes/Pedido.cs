using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R24.ChangeUniToBi.antes
{
    class Pedido
    {
        public Cliente Cliente { get; set; }
    }

    class Cliente
    {
        private HashSet<Pedido> _pedidos = new HashSet<Pedido>();
        public IEnumerable<Pedido> Pedidos
        {
            get { return _pedidos; }
        }
    }
}
