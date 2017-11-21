using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R24.ChangeUniToBi.depois
{
    class Pedido : IDisposable
    {
        private Cliente cliente;
        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }
        }

        public Pedido(Cliente cliente)
        {
            this.cliente = cliente;
            this.cliente.Adiciona(this);
        }

        public void Dispose()
        {
            this.cliente = null;
        }
    }

    class Cliente
    {
        private HashSet<Pedido> pedidos = new HashSet<Pedido>();
        public IEnumerable<Pedido> Pedidos
        {
            get { return pedidos; }
        }

        internal HashSet<Pedido> PedidosDeAmigos
        {
            get { return pedidos; }
        }

        public void Adiciona(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        public void Remove(Pedido pedido)
        {
            pedidos.Remove(pedido);
        }
    }
}
