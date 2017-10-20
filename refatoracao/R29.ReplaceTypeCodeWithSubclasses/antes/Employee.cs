using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R29.ReplaceTypeCodeWithSubclasses.antes
{
    class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int Type { get; private set; }

        private Employee(int type)
        {
            Type = type;
        }

        public static Employee Create(int type)
        {
            return new Employee(type);
        }
    }
}
