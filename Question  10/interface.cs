using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__10
{
    public class ExecutionEngine<T> where T : IDisposable
    {
        public void ExecuteAndDispose(T Item)
        {
            Console.WriteLine("Executing...");
            Item.Dispose();
        }
    }
}
