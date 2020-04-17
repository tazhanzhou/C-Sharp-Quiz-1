using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Quiz_1
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
}
