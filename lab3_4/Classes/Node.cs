using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4.Classes
{
    public abstract class Node
    {
        protected Random random;
        protected NodeListener nodeListener;
        
        public bool Success { get; protected set; }
        public int Id { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public double ChanceValue { get; private set; }
        public bool CanDropValue { get; set; }
        public abstract void TransportValueFurther();
        public abstract void Work();
        public Node(double chance, bool canDropValue, NodeListener listener)
        {
            if(chance < 0.0 || chance > 100.0)
            {
                throw new ArgumentException("Chance can't be lower than 0 or greater than 100");
            }

            if(listener == null)
            {
                throw new ArgumentException("Listener can't be null");
            }

            random = new Random();
            ChanceValue = chance;
            CanDropValue = canDropValue;
            nodeListener = listener;
        }

        public void DropValue() // change it, if i will have time
        {
            if (CanDropValue)
            {
                nodeListener.ValueWasDropped();
            }
        }
    }
}
