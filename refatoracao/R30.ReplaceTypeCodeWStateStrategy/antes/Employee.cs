using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R30.ReplaceTypeCodeWStateStrategy.antes
{
    class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int Type { get; set; }

        public int Salary { get; private set; }
        public int Comission { get; private set; }
        public int Bonus { get; private set; }

        private Employee(int type)
        {
            Type = type;
        }

        public int GetPayAmount()
        {
            switch (Type)
            {
                case ENGINEER:
                    return Salary;
                case SALESMAN:
                    return Salary + Comission;
                case MANAGER:
                    return Salary + Bonus;
                default:
                    break;
            }
            throw new Exception("Unknown type");
        }

        public static Employee Create(int type)
        {
            return new Employee(type);
        }
    }
}
