using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R55.PullUpConstructorBody.depois
{
    class Funcionario
    {
        protected string nome;
        protected string id;

        public Funcionario(string nome, string id)
        {
            this.nome = nome;
            this.id = id;
        }
    }

    class Gerente : Funcionario
    {
        private int avaliacao;
        public Gerente(string nome, string id, int avaliacao) : base(nome, id)
        {
            this.avaliacao = avaliacao;
        }
    }

}
