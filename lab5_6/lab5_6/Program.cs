using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Transactions;

namespace lab5_6
{
    class Program
    {
        private const double HOURS_IN_DAY = 24;
        private const double MINUTES_IN_HOURS = 60;
        private static List<ConsoleColor> _colors;

        public static Dictionary<string, int> StatesStats { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("Enter intensity: ");
            var intensity = Convert.ToDouble(Console.ReadLine()) ;
            Console.Write("Enter m: ");
            var avgTime = MINUTES_IN_HOURS * Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter delta time: ");
            var dt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Time: ");
            var N = Convert.ToDouble(Console.ReadLine());

            intensity = 1 - intensity / HOURS_IN_DAY / MINUTES_IN_HOURS * dt;

            StatesStats = new Dictionary<string, int>();

            Dictionary<NodeState, Func<Node, double>> generators = new Dictionary<NodeState, Func<Node, double>>();
            generators.Add(NodeState.Working, GetChance);
            generators.Add(NodeState.Repairing, ErlongChance);

            Node[] nodes = {
                new Node(2, dt,new double[] {intensity, 2.0 / avgTime}, generators),
                new Node(2, dt,new double[] {intensity, 2.0 / avgTime}, generators), 
            };

            _colors = new List<ConsoleColor>();

            _colors.Add(ConsoleColor.Red);
            _colors.Add(ConsoleColor.Green);
            _colors.Add(ConsoleColor.Yellow);
            _colors.Add(ConsoleColor.Blue);


            for (int i = 0; i < N; i++) // ticks
            {
                var state = "";
                for (int j = 0; j < nodes.Length; j++) // execution in wach node
                {
                    nodes[j].Tick();
                    state += (int)nodes[j].StateInfo.State;
                }

                CollectStats(state);

                if (StatesStats.ContainsKey("10") && StatesStats.ContainsKey("01")) 
                {
                    if (StatesStats["10"] > StatesStats["00"] || StatesStats["01"] > StatesStats["00"])
                    {
                        var temp = 0;
                    }
                }
            }

            CalcAndPrintStats(N);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void CalcAndPrintStats(double ticksCount)
        {
            double sum = 0;
            int i = 0;
            var prevColor = Console.ForegroundColor;

            foreach (var item in StatesStats)
            {
                Console.ForegroundColor = _colors[i];
                double chance = Math.Round((double)item.Value / (double)ticksCount, 10);
                Console.WriteLine(String.Format("P({0}) = {1}", item.Key, chance));
                sum += chance;
                i++;
            }

            Console.ForegroundColor = prevColor;

            Console.WriteLine("Sum = " + sum);

        }

        public static void CollectStats(string state)
        {
            if (!StatesStats.ContainsKey(state))
            {
                StatesStats.Add(state, 0);
            }

            StatesStats[state]++;
        }

        private static void PrintStats()
        {
            foreach (var item in StatesStats)
            {
                Console.WriteLine("__________________________________");
                Console.WriteLine(item.Key + " = " + item.Value);
                Console.WriteLine("\n__________________________________");
            }
        }

        public static double GetChance(Node node)
        {
            return node.StateInfo.IntensityValues[(int)node.StateInfo.State];
        }

        public static double ErlongChance(Node node)
        {
            double temp = node.StateInfo.IntensityValues[(int)node.StateInfo.State];
            return temp * temp * node.T * Math.Pow(Math.E, -1 * temp * node.T) * node.DT;
        }
    }
}