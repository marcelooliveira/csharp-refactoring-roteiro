using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace refatoracao.R24.ChangeUniToBi.antes
{
    class Program
    {
        void Main()
        {
            var cliente = new Cliente();
            var pedido = new Pedido();

            cliente.AdicionaPedido(pedido);
            cliente.RemovePedido(pedido);
        }
    }

    class Pedido
    {
        //Código do pedido aqui...
    }

    class Cliente
    {
        private IList<Pedido> pedidos = new List<Pedido>();
        public IReadOnlyCollection<Pedido> Pedidos
        {
            get { return new ReadOnlyCollection<Pedido>(pedidos); }
        }

        internal void AdicionaPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        internal void RemovePedido(Pedido pedido)
        {
            pedidos.Remove(pedido);
        }

        //Mais código do cliente aqui...
    }
}
