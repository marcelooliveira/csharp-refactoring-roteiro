using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R28.ReplaceTypeCodeWithClass.depois
{
    class Person
    {
        public int BloodGroup { get; private set; }

        public Person(int bloodGroup)
        {
            BloodGroup = bloodGroup;
        }
    }

    class BloodGroup
    {
        public static BloodGroup O = new BloodGroup(0);
        public static BloodGroup A = new BloodGroup(1);
        public static BloodGroup B = new BloodGroup(2);
        public static BloodGroup AB = new BloodGroup(3);

        private int Code { get; set; }

        public BloodGroup(int code)
        {
            Code = code;
        }

        public override bool Equals(object obj)
        {
            return Code.Equals((BloodGroup)obj);
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }
    }
}
