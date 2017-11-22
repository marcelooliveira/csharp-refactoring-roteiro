using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R31.ReplaceSubclassWithFields.depois
{
    class Paciente
    {
        public char Sexo { get; private set; }

        private Paciente(char sexo)
        {
            Sexo = sexo;
        }

        public static Paciente CriarPacienteHomem()
        {
            return new Paciente('M');
        }

        public static Paciente CriarPacienteMulher()
        {
            return new Paciente('F');
        }
    }

    class Hospital
    {
        void Teste()
        {
            var maria = Paciente.CriarPacienteMulher();
            var jose = Paciente.CriarPacienteHomem();

            Atender(maria);
            Atender(jose);
        }

        void Atender(Paciente paciente)
        {
            //codigo para atendimento hospitalar...
        }
    }
}
