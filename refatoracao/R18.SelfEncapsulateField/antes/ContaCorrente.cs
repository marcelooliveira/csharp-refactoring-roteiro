using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R18.SelfEncapsulateField.antes
{
    class ContaCorrente
    {
        public decimal saldo;

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
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
