using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R55.PullUpConstructorBody.antes
{
    class Funcionario
    {
        protected string _nome;
        protected string _id;
    }

    class Gerente : Funcionario
    {
        private int _avaliacao;
        public Gerente(string nome, string id, int avaliacao)
        {
            _nome = nome;
            _id = id;
            _avaliacao = avaliacao;
        }
    }

}
