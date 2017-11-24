using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R20.ChangeValueToReference.antes
{
    class Programa
    {
        void Main()
        {
            var prova = new Prova("João Snow");
            Console.WriteLine($"Nome do aluno: {prova.NomeAluno}");

            IList<Prova> provas = new List<Prova>();
            provas.Add(prova);
            Console.WriteLine($"Nº de provas do aluno: {Prova.NumeroDeProvasPara(provas, "João Snow")}");
        }
    }

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

        public static int NumeroDeProvasPara(IEnumerable<Prova> provas, string aluno)
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
