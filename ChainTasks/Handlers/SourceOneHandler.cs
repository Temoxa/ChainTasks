using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChainTasks.Handlers
{
    public class SourceOneHandler : IDataHandler
    {
        public void ConfigureTask(DataModel model)
        {
            Console.WriteLine($"Source One 1");
            Thread.Sleep(3000);
            Console.WriteLine($"Source One 2 {model.FIO}");
        }
    }
}
