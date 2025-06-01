using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BaseNamespace;
namespace ClientNamespace
{
    public class Client : Base
    {

        public string Live_Address { get; set; }
        public string Work_Address { get; set; }
        public double Salary { get; set; }



        public Client(string name, string surname, int age, string liveAddress,
           double salary, string workAddress)
        : base(name, surname, age)
        {
            Live_Address = liveAddress;
            Work_Address = workAddress;
            Salary = salary;
        }
    }
}