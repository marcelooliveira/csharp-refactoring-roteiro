using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R28.ReplaceTypeCodeWithClass.antes
{
    class Person
    {
        public static int O = 0;
        public static int A = 1;
        public static int B = 2;
        public static int AB = 3;

        public int BloodGroup { get; private set; }

        public Person(int bloodGroup)
        {
            BloodGroup = bloodGroup;
        }
    }
}
