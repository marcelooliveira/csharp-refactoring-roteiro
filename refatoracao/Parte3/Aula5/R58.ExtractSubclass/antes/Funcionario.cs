using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R58.ExtractSubclass.antes
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

        protected TipoFuncionario tipo;
        public TipoFuncionario Tipo { get; }

        protected string nome;
        public string Nome => nome;

        protected decimal salario;
        public decimal Salario => salario;

        private decimal comissao;
        public decimal Comissao => comissao;

        private decimal bonus;
        public decimal Bonus => bonus;

        public Funcionario(TipoFuncionario tipo, string nome, decimal salario)
        {
            this.tipo = tipo;
            this.nome = nome;
            this.salario = salario;
        }

        public void DefinirComissao(decimal comissao)
        {
            if (comissao < 0)
            {
                throw new ArgumentException("Comissão não pode ser negativa");
            }

            if (comissao > .25m)
            {
                throw new ArgumentException("Comissão não pode exceder 25%");
            }

            this.comissao = comissao;
        }

        public void DefinirBonus(decimal bonus)
        {
            if (bonus < 0)
            {
                throw new ArgumentException("Bônus não pode ser negativo");
            }

            if (bonus > salario)
            {
                throw new ArgumentException("Bônus não pode ser maior que o salário");
            }

            this.bonus = bonus;
        }
    }
}
