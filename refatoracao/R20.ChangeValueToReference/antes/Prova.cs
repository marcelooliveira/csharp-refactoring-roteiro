using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R20.ChangeValueToReference.antes
{
    class Prova
    {
        private Aluno _aluno;
        public string NomeAluno
        {
            get { return _aluno.nome;}
            set { _aluno = new Aluno(value); }
        }

        public Prova(string nomeAluno)
        {
            _aluno = new Aluno(nomeAluno);
        }

        private static int NumeroDeProvasPara(IEnumerable<Prova> provas, string aluno)
        {
            return provas.Count(o => o.NomeAluno.Equals(aluno, StringComparison.CurrentCultureIgnoreCase));
        }
    }

    class Aluno
    {
        public readonly string nome;
        public Aluno(string nome)
        {
            this.nome = nome;
        }

        public override bool Equals(object obj)
        {
            return nome.Equals(obj);
        }

        public override int GetHashCode()
        {
            return nome.GetHashCode();
        }
    }
}
