using System;
using ChainTasks.Handlers;

namespace ChainTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var manager = new ManagerHandler();
            manager.AddHandler(new SourceOneHandler());
            manager.AddHandler(new SourceTwoHandler());

            manager.Process(new DataModel() { FIO = "Test", INN = "123" });

            Console.WriteLine("Main the end!");

            Console.ReadLine();
        }
    }
}
