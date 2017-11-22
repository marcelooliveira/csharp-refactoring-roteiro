using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R31.ReplaceSubclassWithFields.antes
{
    abstract class Paciente
    {
        public abstract char GetSexo();
    }

    class Homem : Paciente
    {
        public override char GetSexo()
        {
            return 'M';
        }
    }

    class Mulher : Paciente
    {
        public override char GetSexo()
        {
            return 'F';
        }
    }

    class Hospital
    {
        void Teste()
        {
            var maria = new Mulher();
            var jose = new Homem();

            Atender(maria);
            Atender(jose);
        }

        void Atender(Paciente paciente)
        {
            //codigo para atendimento hospitalar...
        }
    }
}
