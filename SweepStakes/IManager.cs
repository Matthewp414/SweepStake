using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    interface IManager
    {
        public void InsertSweepstakes(SweepStakes sweepstakes);
        public SweepStakes GetSweepstakes();

    }
}
