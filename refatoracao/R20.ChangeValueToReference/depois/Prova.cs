using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R20.ChangeValueToReference.depois
{
    class Programa
    {
        void Main()
        {
            var prova = new Prova("João Snow");
            Console.WriteLine($"Nome do aluno: {prova.Aluno.Nome}");

            IList<Prova> provas = new List<Prova>();
            provas.Add(prova);
            Console.WriteLine($"Nº de provas do aluno: {Prova.NumeroDeProvasPara(provas, "João Snow")}");
        }
    }

    class Prova
    {
        private readonly Aluno _aluno;
        public Aluno Aluno
        {
            get { return _aluno;}
        }

        public Prova(string nomeAluno)
        {
            _aluno = Aluno.GetAluno(nomeAluno);
        }

        public static int NumeroDeProvasPara(IEnumerable<Prova> provas, string aluno)
        {
            return provas.Count(o => o.Aluno.Nome.Equals(aluno, StringComparison.CurrentCultureIgnoreCase));
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
