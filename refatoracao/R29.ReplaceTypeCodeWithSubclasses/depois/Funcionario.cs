using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R29.ReplaceTypeCodeWithSubclasses.depois
{
    abstract class Funcionario
    {
        public const int ENGENHEIRO = 0;
        public const int VENDEDOR = 1;
        public const int GERENTE = 2;

        public abstract int Tipo { get; }

        public static Funcionario Criar(int tipo)
        {
            switch (tipo)
            {
                case ENGENHEIRO:
                    return new Engenheiro();
                case VENDEDOR:
                    return new Vendedor();
                case GERENTE:
                    return new Gerente();
                default:
                    break;
            }
            throw new Exception("Tipo desconhecido");
        }
    }

    class Engenheiro : Funcionario
    {
        public override int Tipo => Funcionario.ENGENHEIRO;
    }

    class Vendedor : Funcionario
    {
        public override int Tipo => Funcionario.VENDEDOR;
    }

    class Gerente : Funcionario
    {
        public override int Tipo => Funcionario.GERENTE;
    }
}
