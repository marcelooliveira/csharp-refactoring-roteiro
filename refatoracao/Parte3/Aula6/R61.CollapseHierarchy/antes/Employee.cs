using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R61.CollapseHierarchy.antes
{
    abstract class Employee
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    class Salesman: Employee
    {
        public string MobileNumber { get; set; }
    }
}
