using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab3_4.Classes
{
    public class MarkovChain
    {
        public NodeListener Listener { get; private set; }
        public WorkStatistics Statistics { get; private set; }
        public Node StartNode { get; private set; }

        public int TiksCount { get; set; }
        public MarkovChain()
        {
            Statistics = new WorkStatistics();
            Listener = new NodeListener(Statistics);
        }

        public bool IntializeChain(params Node[] nodes)
        {
            int index = 0;
            if (nodes.Length == 0)
            {
                return false;
            }

            StartNode = nodes[0];

            Node temp = StartNode;
            Node prevNode = null;
            for (int i = 0; i < nodes.Length-1; i++)
            {
                temp.Id = index++;
                temp.Next = nodes[i+1];
                temp.Previous = prevNode;
                prevNode = temp;
                temp = temp.Next;
            }

            temp.Previous = prevNode;
            return true;
        }

        private void Tik()
        {
            Node temp = StartNode;
            
            while (temp != null)
            {
                temp.Work();
                temp = temp.Next;
            }
        }

        private void RefreshState()
        {
            Node temp = StartNode;
            string stateString = "";
            int currReqCount = 0;
            while (temp != null)
            {
                if (!(temp is Generator))
                {
                    (temp as BlockableNode).RefreshState();
                    stateString += (temp as BlockableNode).Value.ToString();
                    currReqCount += (temp as BlockableNode).Value;
                }
                temp = temp.Next;
            }

            Statistics.AddQueueValue(Convert.ToInt32(stateString[1].ToString()));
            Statistics.AddRequestsInSystemCount(currReqCount);
            Statistics.SaveState(stateString);
        }

        public void Work()
        {
            for (int i = 0; i < TiksCount; i++)
            {
                Tik();
                RefreshState();
            }

            Statistics.CalculateCharacteristics(TiksCount);
        }
    }
}
