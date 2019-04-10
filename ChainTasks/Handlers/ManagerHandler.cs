using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainTasks.Handlers
{
    public class ManagerHandler
    {
        private List<IDataHandler> _handlers = new List<IDataHandler>();

        public void AddHandler(IDataHandler handler)
        {
            this._handlers.Add(handler);
        }

        public void Process(DataModel model)
        {
            var tasks = new Task[this._handlers.Count];

            for (int i = 0; i < this._handlers.Count; i++)
            {
                var j = i;
                tasks[i] = new Task(() => 
                {
                    try
                    {
                        if (j == 0)
                            throw new Exception("Test");
                        this._handlers[j].ConfigureTask(model);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine($"ERROR {e.Message}");
                    }
                });
                tasks[i].Start();
            }
        }
    }
}
