using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R27.EncapsulateCollection.antes
{
    class Aluno
    {
        private readonly List<Curso> cursos;
        internal List<Curso> Cursos { get => cursos; }

        public Aluno()
        {
            cursos = new List<Curso>();
        }
    }

    class Curso
    {

    }
}
