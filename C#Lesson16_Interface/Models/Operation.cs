using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankNamespace;

namespace OperationNameSpace
{
    public class Operation : Bank, IBank
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string ProcessName { get; set; }
        public DateTime ProsesStarted { get; set; }



        public Operation(string processName, DateTime prosesStarted)
        {
            ProcessName = processName;
            ProsesStarted = prosesStarted;
        }
    }
}