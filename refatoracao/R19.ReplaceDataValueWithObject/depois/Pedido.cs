using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R19.ReplaceDataValueWithObject.depois
{
    class Pedido
    {
        public readonly Cliente cliente;
        public Cliente Cliente { get; }

        public Pedido(Cliente cliente)
        {
            this.cliente = cliente;
        }

        private static int QuantidadeDePedidosDe(IEnumerable<Pedido> pedidos, Cliente cliente)
        {
            return pedidos
                .Count(p =>
                    p.Cliente.Equals(cliente));
        }
    }

    class Cliente
    {
        private string nome;


        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public Cliente(string nome)
        {
            this.nome = nome;
        }

        public override bool Equals(object obj)
        {
            return this.nome.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}
