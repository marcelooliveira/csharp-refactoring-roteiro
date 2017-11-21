using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R18.SelfEncapsulateField.depois
{
    class ContaCorrente
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
        }

        public ContaCorrente(decimal saldo)
        {
            this.saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            this.saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }
    }
}
