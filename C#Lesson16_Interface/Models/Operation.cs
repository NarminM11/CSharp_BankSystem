using IBankNamespace;
using BaseEntityNamespace;
namespace OperationNameSpace
{
    public class Operation : BaseEntity, IBank
    {
        public string ProcessName { get; set; }
        public DateTime ProsesStarted { get; set; }


        public Operation(string processName, DateTime prosesStarted)
        {
            ProcessName = processName;
            ProsesStarted = prosesStarted;
        }
    }
}