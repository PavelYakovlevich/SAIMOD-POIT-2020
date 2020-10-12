using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4.Classes
{
    public class HandlerNode : BlockableNode
    {
        public HandlerNode(double chance, bool canDropValue, NodeListener listener) : 
            base(chance, canDropValue, listener)
        {
        }

        public override void RefreshState()
        {
            // 
        }

        public override void TransportValueFurther()
        {
            if (Next != null) 
            { 
                (Next as BlockableNode).IncomeValue = Value;
            }   
        }

        public override void Work()
        {
            if(Value == 0)
            {
                ReceiveIncomeValue();
                nodeListener.AddRequestInProcess(Id, Value);
                return;
            }

            double chance = random.NextDouble();
            if(chance > ChanceValue) // success
            {
                if (Next == null) // this is End node!
                {
                    nodeListener.ValueWasHandled();
                }
                else
                {
                    TransportValueFurther();
                }

                ReceiveIncomeValue();
            }
            else // fail
            {
                if(IncomeValue == 1)
                {
                    Previous.DropValue();
                }

            }

            nodeListener.AddRequestInProcess(Id, Value);
            IncomeValue = 0;
        }
    }
}
