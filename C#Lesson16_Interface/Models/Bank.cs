using CEONamespace;
using WorkerNamespace;
using ManagerNamespace;
using ClientNamespace;
using IBankNamespace;
namespace BankNamespace
{
    public abstract class Bank
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Profit { get; set; }

        public CEO CEO { get; set; }
        List<Worker> Workers = new List<Worker>();
        List<Manager> Managers = new List<Manager>();
        List<Client> Clients = new List<Client>();


        public void AddClient(Client client)
        {
            Clients.Add(client);
            Console.WriteLine($"Client {client.Name} {client.Surname} added.");
        }

        public void ShowAllCredit()
        {
            foreach (var client in Clients)
            {
                Console.WriteLine($"Client: {client.Name} {client.Surname}");
            }
        }

        public decimal Calculate_Profit()
        {
            return Profit - Budget;
        }


        public void ShowClientCredit(string fullname)
        {
            var client = Clients.Find(c => $"{c.Name} {c.Surname}" == fullname);
            if (client != null)
            {
                Console.WriteLine($"{fullname} found");
            }
            else
            {
                Console.WriteLine($"{fullname} not found");
            }
        }

    }




}