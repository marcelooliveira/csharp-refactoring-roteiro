using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace refatoracao.R27.EncapsulateCollection.depois
{
    class Aluno
    {
        private readonly List<Curso> cursos;
        public ICollection<Curso> Cursos
        {
            get
            {
                return new ReadOnlyCollection<Curso>(cursos);
            }
        }

        public void AddCurso(Curso curso)
        {
            cursos.Add(curso);
        }

        public void RemoveCurso(Curso curso)
        {
            cursos.Remove(curso);
        }

        public Aluno()
        {
            cursos = new List<Curso>();
        }
    }

    class Curso
    {

    }
}
