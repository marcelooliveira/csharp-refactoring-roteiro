using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R51.ReplaceConstructorWithFactoryMethod.antes
{
    class Programa
    {
        void Main()
        {
            Funcionario engenheiro = new Funcionario(Funcionario.TipoFuncionario.Engenheiro, "José da Silva", 1000);
            Funcionario vendedor = new Funcionario(Funcionario.TipoFuncionario.Vendedor, "Maria Bonita", 2000);
            Funcionario gerente = new Funcionario(Funcionario.TipoFuncionario.Gerente, "João das Neves", 3000);

            var valorFolhaDePagamento = 
                engenheiro.Salario 
                + vendedor.Salario 
                + gerente.Salario;
        }
    }

    class Funcionario
    {
        public enum TipoFuncionario
        {
            Engenheiro = 0,
            Vendedor = 1,
            Gerente = 2
        }

        readonly TipoFuncionario tipo;
        public TipoFuncionario Tipo { get; }

        readonly string nome;
        public string Nome => nome;

        readonly decimal salario;
        public decimal Salario => salario;

        public Funcionario(TipoFuncionario tipo, string nome, decimal salario)
        {
            this.tipo = tipo;
            this.nome = nome;
            this.salario = salario;
        }
    }
}
