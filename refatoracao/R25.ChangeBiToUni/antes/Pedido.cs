using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R25.ChangeBiToUni.depois
{
    class Pedido
    {
        private HashSet<Cliente> _clientes = new HashSet<Cliente>();
        public IEnumerable<Cliente> Customers
        {
            get { return _clientes; }
        }

        public void AddCliente(Cliente cliente)
        {
            cliente.PedidosDeAmigos.Add(this);
            _clientes.Add(cliente);
        }

        public void RemoveCliente(Cliente cliente)
        {
            cliente.PedidosDeAmigos.Remove(this);
            _clientes.Remove(cliente);
        }
    }

    class Cliente
    {
        private HashSet<Pedido> _pedidos = new HashSet<Pedido>();
        public IEnumerable<Pedido> Pedidos
        {
            get { return _pedidos; }
        }

        internal HashSet<Pedido> PedidosDeAmigos
        {
            get { return _pedidos; }
        }

        public void AddPedido(Pedido pedido)
        {
            pedido.AddCliente(this);
        }

        public void RemovePedido(Pedido pedido)
        {
            pedido.RemoveCliente(this);
        }
    }
}
