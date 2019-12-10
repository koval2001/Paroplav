namespace Water
{
    public class LakeCreator : ReservoirCreator
    {
        public override string ReservoirType { get { return "lake"; } }

        public override IMethods reservoir()
        {
            return new Lake();
        }
    }
}