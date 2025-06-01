using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNamespace
{
    public class Client
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }


        public Client()
        {
            Id = Guid.NewGuid();
        }

        // Parametrli constructor
        public Client(string name, string surname, int age, string position)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
        }
    }
}
