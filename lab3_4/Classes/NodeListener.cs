using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4.Classes
{
    public class NodeListener
    {
        public WorkStatistics Statistics { get; private set; }
        public NodeListener(WorkStatistics statistics)
        {
            Statistics = statistics;
        }

        public void ValueWasGenerated()
        {
            Statistics.AddNewRequest();
        }

        internal void ValueWasDropped()
        {
            Statistics.AddDropedRequest();
        }

        public void ValueWasHandled()
        {
            Statistics.AddHandledRequestRequest();
        }

        public void AddRequestInProcess(int id, int value)
        {
            Statistics.AddHandledValuesCountByHandlers(id, value);
        }
    }
}
