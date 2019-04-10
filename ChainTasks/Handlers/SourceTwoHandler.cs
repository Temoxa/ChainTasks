using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChainTasks.Handlers
{
    public class SourceTwoHandler : IDataHandler
    {
        public void ConfigureTask(DataModel model)
        {
            Console.WriteLine("Source TWO 1");
            Thread.Sleep(1000);
            Console.WriteLine($"Source TWO 2 {model.INN}");
        }
    }
}
