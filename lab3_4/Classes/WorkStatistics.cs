using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_4.Classes
{
    public class WorkStatistics
    {
        public int RequestsCount { get; private set; }
        public int HandledRequestsCount { get; private set; }
        public int DropedRequestsCount { get; private set; }
        public double DenyChanceValue { get; private set; }
        public double AverageQueueLength { get; private set; }
        public int QueuedValuesCount { get; private set; }
        public int RequestsInSystemCount { get; private set; }
        public double AvgRequestsCountInSystem { get; private set; }
        public double RelativePassAbility { get; private set; }
        public double AbsolutePassAbility { get; private set; }

        public void AddHandledValuesCountByHandlers(int id, int value)
        {
            HandledValuesCountByHandlers[id] += value;
        }

        public double AvgTimeRequestInSystem { get; private set; }
        public double AvgTimeRequestInQueue { get; private set; }
        public Dictionary<string, int> StatesFrequency { get; private set; }
        public List<double> StatesChances { get; private set; }
        public List<int> HandledValuesCountByHandlers { get; private set; }
        public List<double> CanalLoadCoef { get; private set; }

        public WorkStatistics()
        {
            StatesFrequency = new Dictionary<string, int>();
            StatesChances = new List<double>();
            HandledValuesCountByHandlers = new List<int>();
            HandledValuesCountByHandlers.Add(0);
            HandledValuesCountByHandlers.Add(0);
            CanalLoadCoef = new List<double>();
            CanalLoadCoef.Add(0);
            CanalLoadCoef.Add(0);
        }


        public void SaveState(string state)
        {
            if (!StatesFrequency.ContainsKey(state))
            {
                StatesFrequency.Add(state, 1);
                return;
            }

            StatesFrequency[state]++;
        }

        internal void AddHandledValues(int v)
        {
            throw new NotImplementedException();
        }

        public void AddQueueValue(int v)
        {
            QueuedValuesCount += v;
        }

        public void AddHadledReqCountByHandler(int index)
        {
            HandledValuesCountByHandlers[index]++;
        }

        public void AddNewRequest()
        {
            RequestsCount++;
        }

        public void AddHandledRequestRequest()
        {
            HandledRequestsCount++;
        }

        public void AddDropedRequest()
        {
            DropedRequestsCount++;
        }

        public void CalculateCharacteristics(int tiksCount)
        {
            foreach (KeyValuePair<string, int> pair in StatesFrequency)
            {
                double chance = Math.Round((double)pair.Value / (double)tiksCount, 4);
                StatesChances.Add(chance);
            }

            DenyChanceValue = Math.Round(Get0OrNumber((double)DropedRequestsCount / (double)RequestsCount), 4);
            AverageQueueLength = Math.Round(Get0OrNumber((double)QueuedValuesCount / (double)tiksCount), 4); 
            AvgRequestsCountInSystem = Math.Round(Get0OrNumber((double)RequestsInSystemCount / (double)tiksCount), 4);
            RelativePassAbility = Math.Round(1.0 - DenyChanceValue, 4);
            AbsolutePassAbility = Math.Round(Get0OrNumber((double)HandledRequestsCount / (double)tiksCount), 4);
            AvgTimeRequestInSystem = Math.Round(Get0OrNumber((double)RequestsInSystemCount / (double)HandledRequestsCount), 4);
            AvgTimeRequestInQueue = Math.Round(Get0OrNumber((double) QueuedValuesCount / (double) HandledRequestsCount), 4);

            for (int i = 0; i < HandledValuesCountByHandlers.Count; i++)
            {
                CanalLoadCoef[i] = Math.Round((double)HandledValuesCountByHandlers[i] / (double)tiksCount, 4);
            }
        }

        private double Get0OrNumber(double divisionResult)
        {
            if (Double.IsNaN(divisionResult) || Double.IsInfinity(divisionResult) || Double.IsNegativeInfinity(divisionResult) || Double.IsPositiveInfinity(divisionResult))
            {
                return 0.0;
            }

            return divisionResult;
        }

        public void AddRequestsInSystemCount(int currReqCount)
        {
            RequestsInSystemCount += currReqCount;
        }
    }
}
