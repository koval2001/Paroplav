namespace Water
{
    public abstract class ReservoirCreator
    {
        public abstract string ReservoirType { get; }

        public abstract IMethods reservoir();
    }
}