using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace lab5_6
{
    public class Node
    {
        private Random _rand;
        public double pSum;

        public NodeStateInfo StateInfo { get; private set; }
        public int[] StatesStats { get; private set; }
        public Dictionary<NodeState, Func<Node, double>> Generators { get; private set; }
        public double T { get; set; }
        public double DT { get; private set; }


        public Node(int statesCount, double dt, double[] states, Dictionary<NodeState, Func<Node, double>> generators)
        {
            StatesStats = new int[statesCount];
            StateInfo = new NodeStateInfo(NodeState.Working, states);
            Generators = generators;
            _rand = new Random();
            DT = dt;
        }

        private void ChangeState()
        {
            T = 0;
            pSum = 0;
            StateInfo.ChangeState();            
        }

        private double GetChance()
        {
            var extraValue = 1.0; 

            if (StateInfo.State == NodeState.Repairing)
            {
                extraValue = (1.0 - pSum);
            }

            return _rand.NextDouble() * extraValue;
        }

        public void Tick()
        {
            T += DT;

            var chance = Generators[StateInfo.State](this);
            var value = GetChance();
            if (Compare(chance, value))
            {
                ChangeState();
            }
            else
            {
                pSum += chance;
            }
        }

        private bool Compare(double chance, double value)
        {
            if (StateInfo.State == NodeState.Working)
            {
                return chance < value;
            }

            return chance > value;
        }

        public bool AddGenerator(NodeState nodeState, Func<Node, double> func)
        {
            return Generators.TryAdd(nodeState, func);
        }
    }
}
