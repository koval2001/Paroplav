using System;

namespace KovalGroup
{
    public abstract class AboutBook
    {
        public string Name;
        public TimeSpan IceingTime;
        public bool IsRiverOutput;

        public string OutputRiverName()
        {
            return IsRiverOutput ? Name : null;
        }

        public abstract float PartOfTheyearWhenThereIsNoIce();
    }
}
