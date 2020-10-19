namespace lab5_6
{
    public class NodeStateInfo
    {
        public NodeState State { get; private set; }
        public double[] IntensityValues { get; private set; }

        public NodeStateInfo(NodeState state, double[] intensityValues)
        {
            State = state;
            IntensityValues = intensityValues;
        }

        public void ChangeState()
        {
            if (State == NodeState.Repairing)
            {
                State = NodeState.Working;
                return;
            }
            else
            {
                State++;
            }
        }
    }
}
