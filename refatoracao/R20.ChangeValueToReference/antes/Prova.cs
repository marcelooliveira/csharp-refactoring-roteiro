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
            get { return _aluno.Nome;}
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
        public string Nome { get; private set; }
        public Aluno(string nome)
        {
            Nome = nome;
        }

        public override bool Equals(object obj)
        {
            return Nome.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}
