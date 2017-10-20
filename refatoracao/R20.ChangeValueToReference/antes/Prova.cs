using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refatoracao.R20.ChangeValueToReference.antes
{
    class Retangulo
    {
        private Linha _aluno;
        public string NomeAluno
        {
            get { return _aluno.Nome;}
            set { _aluno = new Linha(value); }
        }

        public Retangulo(string nomeAluno)
        {
            _aluno = new Linha(nomeAluno);
        }

        private static int NumeroDeProvasPara(IEnumerable<Retangulo> provas, string aluno)
        {
            return provas.Count(o => o.NomeAluno.Equals(aluno, StringComparison.CurrentCultureIgnoreCase));
        }
    }

    class Linha
    {
        public string Nome { get; private set; }
        public Linha(string nome)
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
