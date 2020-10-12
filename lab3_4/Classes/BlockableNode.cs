using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4.Classes
{
    public abstract class BlockableNode : Node
    {
        protected BlockableNode(double chance, bool canDropValue, NodeListener listener) : 
            base(chance, canDropValue, listener)
        {
        }

        public int IncomeValue { get; set; }
        public int Value { get; protected set; }
        public bool Blocked { get; private set; }

        protected void ReceiveIncomeValue()
        {
            Value = IncomeValue;
            IncomeValue = 0;

            if ((Previous is QueueNode) && (Previous as QueueNode).Value > 0)
            {
                (Previous as QueueNode).DequeueValue();
            }
        }

        public abstract void RefreshState();
    }
}
