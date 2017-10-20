using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R31.ReplaceSubclassWithFields.depois
{
    class Person
    {
        public char Code { get; private set; }

        private Person(char code)
        {
            Code = code;
        }

        static Person CreateMale()
        {
            return new Person('M');
        }

        static Person CreateFemale()
        {
            return new Person('F');
        }
    }

}
