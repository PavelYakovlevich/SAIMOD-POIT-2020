using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4.Classes
{
    class Generator : Node
    {
        public Generator(double chance, bool canDropValue, NodeListener listener) : 
            base(chance, canDropValue, listener)
        {
        }

        private void GenerateValue()
        {
            double chance = random.NextDouble();
            Success = chance > ChanceValue ? true : false;
            if (Success)
            {
                nodeListener.ValueWasGenerated();
            }
        }

        public override void TransportValueFurther()
        {
            (Next as BlockableNode).IncomeValue = Convert.ToInt32(Success);
        }

        public override void Work()
        {
            GenerateValue();
            TransportValueFurther();
        }
    }
}
