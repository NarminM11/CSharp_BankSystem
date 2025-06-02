using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBankNamespace;
using ClientNamespace;
using BaseEntityNamespace;
namespace CreditNamespace
{
    public class Credit : BaseEntity
    {

        public string Months { get; set; }
        public int Percent { get; set; }
        public int Amount { get; set; }

        public Client clients { get; set; }

        public Credit(string months, int percent, int amount)
        {
            Months = months;
            Percent = percent;
            Amount = amount;
        }


        public decimal CalculatePercent()
        {
            return (Amount * Percent * int.Parse(Months)) / 100m;
        }

        public decimal Payment()
        {
            return Amount + CalculatePercent();
        }

    }
}