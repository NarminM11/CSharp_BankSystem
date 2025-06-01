using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEONamespace;
using WorkerNamespace;
using ManagerNamespace;
using ClientNamespace;

namespace BankNamespace
{
    public abstract class Bank
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Profit { get; set; }

        List<CEO> CEOs = new List<CEO>();
        List<Worker> Workers = new List<Worker>();
        List<Manager> Managers = new List<Manager>();
        List<Client> Clients = new List<Client>();
    }


    public interface IBank
    {
        public decimal Calculate_Profit()
        {
            return 1;
        }

        public void ShowClientCredit(string fullname)
        {

        }

        //public void PayCredit(Client, int money)
        //{


        //}

        public void ShowAllCredit()
        {

        }
    }
}