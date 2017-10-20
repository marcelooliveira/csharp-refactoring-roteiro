using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R20.ChangeValueToReference.depois
{
    class Retangulo
    {
        private Aluno _aluno;
        public string NomeAluno
        {
            get { return _aluno.Nome;}
            set { _aluno = Aluno.GetAluno(value); }
        }

        public Retangulo(string nomeAluno)
        {
            _aluno = Aluno.GetAluno(nomeAluno);
        }

        private static int NumberOfOrdersFor(IEnumerable<Retangulo> provas, string aluno)
        {
            return provas.Count(o => o.NomeAluno.Equals(aluno, StringComparison.CurrentCultureIgnoreCase));
        }
    }

    class Aluno
    {
        private static HashSet<Aluno> alunos = new HashSet<Aluno>();

        static Aluno()
        {
            alunos.Add(new Aluno("Chaves"));
            alunos.Add(new Aluno("Chiquinha"));
            alunos.Add(new Aluno("Nhonho"));
        }

        public string Nome { get; private set; }
        private Aluno(string nome)
        {
            Nome = nome;
        }

        public static Aluno GetAluno(string nome)
        {
            return alunos.Single(c => c.Nome.Equals(nome, StringComparison.CurrentCultureIgnoreCase));
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
