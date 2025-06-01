using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkerNamespace
{
    public class Worker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Worker()
        {
            Id = Guid.NewGuid();
        }

        // Parametrli constructor
        public Worker(string name, string surname, int age, string position, int salary, DateTime startTime, DateTime endTime)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            Salary = salary;
            StartTime = startTime;
            EndTime = endTime;
        }
    }

}