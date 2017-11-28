using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R21.ChangeReferenceToValue.antes
{
    class Programa
    {
        public void Main()
        {
            Cliente joao = Cliente.Get("João Snow");
            joao.DataNascimento = new DateTime(1985, 1, 1);
        }
    }

    class Cliente
    {
        private readonly string nome;
        public string Nome { get => nome; }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        { get => dataNascimento; set => dataNascimento = value; }

        private Cliente(string nome)
        {
            this.nome = nome;
        }

        private static IDictionary<string, Cliente> dicionario
            = new Dictionary<string, Cliente>();

        public static Cliente Get(string nome)
        {
            Cliente valor = (Cliente)dicionario[nome];
            if (valor == null)
            {
                valor = new Cliente(nome);
                dicionario.Add(nome, valor);
            }
            return valor;
        }
    }
}
