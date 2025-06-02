using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankNamespace;
using IBankNamespace;
using BaseEmployeeNamespace;
namespace ManagerNamespace
{
    public class Manager : BaseEmployee
    {

        public Manager(string name, string surname, int age, double salary, string position)
          : base(name, surname, age, position, salary)
        {
        }

        public void Organize()
        {
            Console.WriteLine($"[Manager: {Name} {Surname}] Organizing branch operations...");

        }

        public void CalculateSalaries()
        {
            Console.WriteLine($"[Manager: {Name} {Surname}] Calculating team salaries...");

        }
    }
}