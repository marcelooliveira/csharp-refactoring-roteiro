using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R55.PullUpConstructorBody.depois
{
    class Funcionario
    {
        protected string _nome;
        protected string _id;

        public Funcionario(string nome, string id)
        {
            _nome = nome;
            _id = id;
        }
    }

    class Gerente : Funcionario
    {
        private int _avaliacao;
        public Gerente(string nome, string id, int avaliacao) : base(nome, id)
        {
            _avaliacao = avaliacao;
        }
    }

}
