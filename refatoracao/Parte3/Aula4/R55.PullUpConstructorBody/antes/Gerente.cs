using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R55.PullUpConstructorBody.antes
{
    class Funcionario
    {
        protected string nome;
        protected string id;
    }

    class Gerente : Funcionario
    {
        private int avaliacao;
        public Gerente(string nome, string id, int avaliacao)
        {
            base.nome = nome;
            base.id = id;
            this.avaliacao = avaliacao;
        }
    }

}
