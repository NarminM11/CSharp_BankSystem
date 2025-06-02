using IBankNamespace;
using BaseEmployeeNamespace;

namespace WorkerNamespace
{
    public class Worker : BaseEmployee
    {
 
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }



        public Worker(string name, string surname, int age, string position, double salary, DateTime startTime, DateTime endTime)
       : base(name, surname, age, position, salary)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public void Operation()
        {
            TimeSpan duration = EndTime - StartTime;
            double hoursWorked = duration.TotalHours;
            Console.WriteLine($"Worker: {Name} {Surname}");
            Console.WriteLine($" • Position: {Position}");
            Console.WriteLine($" • Worked from {StartTime:G} to {EndTime:G}");
            Console.WriteLine($" • Total hours worked: {hoursWorked:F2} hours");
        }

        public void AddOpertion()
        {

        }
    }

}