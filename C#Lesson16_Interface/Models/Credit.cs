using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankNamespace;
using ClientNamespace;

namespace CreditNamespace
{
    public class Credit : Bank, IBank
    {

        public Guid Id { get; set; }
        public string Months { get; set; }
        public int Percent { get; set; }
        public int Amount { get; set; }

        public Client clients { get; set; }

        public Credit()
        {
            Id = Guid.NewGuid();
        }

        public Credit(string months, int percent, int amount)
        {
            Id = Guid.NewGuid();
            Months = months;
            Percent = percent;
            Amount = amount;
        }

        public decimal CalculatePercent()
        {
            return 1;
                
        }
    }
}