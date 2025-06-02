using BankNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Lesson16_Interface.Models
{
    public class MyBank : Bank
    {
        public MyBank(string name, decimal budget, decimal profit)
        {
            Name = name;
            Budget = budget;
            Profit = profit;
        }
    }

}
