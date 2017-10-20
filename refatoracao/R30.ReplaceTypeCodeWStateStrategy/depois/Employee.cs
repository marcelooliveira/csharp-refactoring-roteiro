using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R30.ReplaceTypeCodeWStateStrategy.depois
{
    class Employee
    {
        private EmployeeType Type { get; set; }

        public decimal Salary { get; private set; }
        public decimal Comission { get; private set; }
        public decimal Bonus { get; private set; }

        public Employee(EmployeeType type)
        {
            Type = type;
        }
    }

    abstract class EmployeeType
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public abstract int Type { get; }

        public static EmployeeType Create(int type)
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
        public abstract decimal GetPayAmount(Employee employee);
    }

    class Engineer : EmployeeType
    {
        public override int Type => ENGINEER;
        public override decimal GetPayAmount(Employee employee)
        {
            return employee.Salary;
        }
    }

    class Salesman : EmployeeType
    {
        public override int Type => SALESMAN;
        public override decimal GetPayAmount(Employee employee)
        {
            return employee.Salary + employee.Comission;
        }
    }

    class Manager : EmployeeType
    {
        public override int Type => MANAGER;
        public override decimal GetPayAmount(Employee employee)
        {
            return employee.Salary + employee.Bonus;
        }
    }
}
