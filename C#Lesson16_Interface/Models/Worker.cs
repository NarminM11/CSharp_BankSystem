using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BankNamespace;

namespace WorkerNamespace
{
    public class Worker : Bank, IBank
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

        public void Operation()
        {
            TimeSpan duration = EndTime - StartTime;
            double hoursWorked = duration.TotalHours;
            Console.WriteLine($"[Worker: {Name} {Surname}]");
            Console.WriteLine($" • Position: {Position}");
            Console.WriteLine($" • Worked from {StartTime:G} to {EndTime:G}");
            Console.WriteLine($" • Total hours worked: {hoursWorked:F2} hours");
        }

        public void AddOpertion()
        {

        }
    }

}