using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace refatoracao.R24.ChangeUniToBi.depois
{
    class Program
    {
        void Main()
        {
            var cliente = new Cliente();

            Pedido pedido = cliente.AdicionaPedido();
            cliente.RemovePedido(pedido);
        }
    }

    class Pedido
    {
        private readonly Cliente cliente;
        internal Cliente Cliente => cliente;

        public Pedido(Cliente cliente)
        {
            this.cliente = cliente;
        }

        //Código do pedido aqui...
    }

    class Cliente
    {
        private IList<Pedido> pedidos = new List<Pedido>();
        public IReadOnlyCollection<Pedido> Pedidos
        {
            get { return new ReadOnlyCollection<Pedido>(pedidos); }
        }

        internal Pedido AdicionaPedido()
        {
            var pedido = new Pedido(this);
            pedidos.Add(pedido);
            return pedido;
        }

        internal void RemovePedido(Pedido pedido)
        {
            pedidos.Remove(pedido);
        }

        //Mais código do cliente aqui...
    }
}
