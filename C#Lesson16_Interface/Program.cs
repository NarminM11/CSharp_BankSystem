using BankNamespace;
using CreditNamespace;
using ManagerNamespace;
using WorkerNamespace;
using IBankNamespace;
using ClientNamespace;
using C_Lesson16_Interface.Models;
using static IBankNamespace.IBank;
public class HelloWorld
{
    static void Main(string[] args)
    {
        Worker worker = new Worker("Narmin", "Murshudova", 30, "Developer", 1000, DateTime.Now, DateTime.Now.AddHours(8));
        Manager manager = new Manager("Rafig", "Javadov", 40, 2500, "Senior");
        Credit credit = new Credit("12", 10, 1000);

        worker.Operation();
        manager.Organize();

        MyBank bank = new MyBank("Kapital Bank", 100000, 120000);
        bank.AddClient(new Client("Elvin", "Quliyev", 28, "Bakı", 2000, "Bakı"));
        bank.ShowAllCredit();
    }

}