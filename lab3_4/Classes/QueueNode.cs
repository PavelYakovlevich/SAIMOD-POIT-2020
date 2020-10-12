using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4.Classes
{
    public class QueueNode : BlockableNode
    {
        public int Size { get; private set; }
        public QueueNode(bool canDropValue, int size, NodeListener listener) : 
            base(1, canDropValue, listener)
        {
            Size = size;
        }

        public override void TransportValueFurther()
        {
            (Next as BlockableNode).IncomeValue = Value > 0 ? 1 : 0;
        }

        public override void Work()
        {
            if (IncomeValue == 1)
            {
                if (Value < Size) // no space in queue
                {
                    Value++;
                    IncomeValue = 0;
                }
            }

            TransportValueFurther();
        }

        public void DequeueValue()
        {
            Value--;
        }

        public override void RefreshState()
        {
            if (IncomeValue == 1)
            {
                if (Value < Size)
                {
                    Value++;
                }
                else
                {
                    Previous.DropValue();
                }
            }

            IncomeValue = 0;
        }
    }
}
