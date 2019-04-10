using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainTasks.Handlers
{
    public interface IDataHandler
    {
        void ConfigureTask(DataModel model);
    }
}
