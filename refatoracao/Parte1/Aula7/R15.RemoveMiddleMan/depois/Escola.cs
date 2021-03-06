﻿using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R15.RemoveMiddleMan.depois
{
    class Escola
    {
        public string Nome { get; private set; }
        public Funcionario Diretor { get; private set; }
    }

    class Departamento
    {
        public Escola Escola { get; private set; }
    }

    class Funcionario
    {
        private Departamento Departamento { get; }
        public Funcionario Diretor
        {
            get
            {
                return Departamento.Escola.Diretor;
            }
        }
    }

    class Teste
    {
        public Teste()
        {
            var maria = new Funcionario();
            var diretorDaMaria = maria.Diretor;
        }
    }
}
