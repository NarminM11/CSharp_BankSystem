using ClientNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBankNamespace
{
    public interface IBank
    {
        public interface IBank
        {
            decimal Calculate_Profit();
            void ShowClientCredit(string fullname);
            void PayCredit(Client client, decimal money);
            void ShowAllCredit();
        }


    }
}
