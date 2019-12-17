using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Qmanager : IManager
    {
        Queue<SweepStakes> SweepStakeQ;
        public Qmanager()
        {
            SweepStakeQ = new Queue<SweepStakes>();
        }
        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            SweepStakeQ.Enqueue(sweepstakes);

        }
        public SweepStakes GetSweepstakes()
        {
            SweepStakes NextUp = SweepStakeQ.Dequeue();
            return NextUp ;
        }


    }
}
