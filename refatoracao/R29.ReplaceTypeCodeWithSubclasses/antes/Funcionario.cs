using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R29.ReplaceTypeCodeWithSubclasses.antes
{
    class Funcionario
    {
        public enum TipoFuncionario
        {
            Engenheiro = 0,
            Vendedor = 1,
            Gerente = 2
        }

        public TipoFuncionario Tipo { get; private set; }

        private Funcionario(TipoFuncionario tipo)
        {
            Tipo = tipo;
        }

        public static Funcionario Criar(TipoFuncionario tipo)
        {
            return new Funcionario(tipo);
        }
    }

    class Exemplo
    {
        void Teste()
        {
            Funcionario engenheiro = Funcionario.Criar(Funcionario.TipoFuncionario.Engenheiro);
            Funcionario vendedor = Funcionario.Criar(Funcionario.TipoFuncionario.Vendedor);
            Funcionario gerente = Funcionario.Criar(Funcionario.TipoFuncionario.Gerente);
        }
    }
}
