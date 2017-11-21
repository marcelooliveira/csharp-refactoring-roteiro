using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R28.ReplaceTypeCodeWithClass.antes
{
    class ContaBancaria
    {
        public static int CONTA_CORRENTE = 0;
        public static int POUPANCA = 1;
        public static int INVESTIMENTO = 2;


        private readonly int tipoConta;
        public int TipoConta
        {
            get
            {
                return tipoConta;
            }
        }

        private decimal saldo;
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }

        public ContaBancaria(int tipoConta, decimal saldoInicial)
        {
            this.tipoConta = tipoConta;
            this.saldo = saldoInicial;
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
