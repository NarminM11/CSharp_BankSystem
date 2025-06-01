using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEONamespace
{
    public class CEO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public CEO()
        {
            Id = Guid.NewGuid(); 
        }

        public CEO(string name, string surname, int age, string position, int salary)
        {
            Id = Guid.NewGuid(); 
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            Salary = salary;
        }
    }
}
