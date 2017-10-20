using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R29.ReplaceTypeCodeWithSubclasses.depois
{
    abstract class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public abstract int Type { get; }

        public static Employee Create(int type)
        {
            switch (type)
            {
                case ENGINEER:
                    return new Engineer();
                case SALESMAN:
                    return new Salesman();
                case MANAGER:
                    return new Manager();
                default:
                    break;
            }
            throw new Exception("Unknown type");
        }
    }

    class Engineer : Employee
    {
        public override int Type => Employee.ENGINEER;
    }

    class Salesman : Employee
    {
        public override int Type => Employee.SALESMAN;
    }

    class Manager : Employee
    {
        public override int Type => Employee.MANAGER;
    }
}
