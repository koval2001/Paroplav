using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParoplavProject
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
