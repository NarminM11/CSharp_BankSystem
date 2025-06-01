using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditNamespace
{
    public class Credit
    {

        public Guid Id { get; set; }
        public string Months { get; set; }
        public int Percent { get; set; }
        public int Amount { get; set; }


        public Credit()
        {
            Id = Guid.NewGuid(); // Unikal ID avtomatik təyin olunur
        }

        // Parametrli constructor
        public Credit(string months, int percent, int amount)
        {
            Id = Guid.NewGuid(); // Unikal ID avtomatik təyin olunur
            Months = months;
            Percent = percent;
            Amount = amount;
        }
    }
}
