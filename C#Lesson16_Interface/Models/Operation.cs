using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationNameSpace
{
    public class Operation
    {
        public Guid Id { get; set; }

        public string ProcessName { get; set; }


        public Operation()
        {
            Id = Guid.NewGuid(); // Unikal ID avtomatik verilir
        }

        // Parametrli constructor
        public Operation(string processName)
        {
            Id = Guid.NewGuid(); // Unikal ID avtomatik verilir
            ProcessName = processName;
        }
    }
}
