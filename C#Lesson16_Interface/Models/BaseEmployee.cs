using BaseNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEmployeeNamespace
{
    public abstract class BaseEmployee : Base
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public BaseEmployee(string name, string surname, int age, string position, double salary)
            : base(name, surname, age)
        {
            Position = position;
            Salary = salary;
        }
    }

}
