using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R24.ChangeUniToBi.depois
{
    class Pedido
    {
        private HashSet<Cliente> _clientes = new HashSet<Cliente>();
        public IEnumerable<Cliente> Clientes
        {
            get { return _clientes; }       
        }

        public void Adiciona(Cliente cliente)
        {
            cliente.PedidosDeAmigos.Add(this);
            _clientes.Add(cliente);
        }

        public void Remove(Cliente cliente)
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

        public void Adiciona(Pedido pedido)
        {
            pedido.Adiciona(this);
        }

        public void Remove(Pedido pedido)
        {
            pedido.Remove(this);
        }
    }
}
