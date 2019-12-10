namespace Water
{
    public class PondCreator : ReservoirCreator
    {
        public override string ReservoirType { get { return "pond"; } }

        public override IMethods reservoir()
        {
            return new Pond();
        }
    }
}