using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Parte3.Aula6.R64.ReplaceDelegationWithInheritance.depois
{
    class Person
    {
        private String name;

        public String Name { get => name; set => this.name = value; }

        public String LastName => name.Substring(name.LastIndexOf(' ') + 1);
    }

    class Employee
    {
        protected Person person;

        public Employee()
        {
            this.person = new Person();
        }
        public String Name { get => person.Name; set => person.Name = value; }

        override public String ToString()
        {
            return "Emp: " + person.LastName;
        }
    }
}
