using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R31.ReplaceSubclassWithFields.antes
{
    abstract class Person
    {
        public abstract char GetCode();
    }

    class Male : Person
    {
        public override char GetCode()
        {
            return 'M';
        }
    }

    class Female : Person
    {
        public override char GetCode()
        {
            return 'F';
        }
    }
}
