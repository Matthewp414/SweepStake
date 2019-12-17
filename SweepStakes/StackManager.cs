using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class StackManager : IManager
    {
        Stack<SweepStakes> SweepStakeStack;
        public StackManager()
        {
            SweepStakeStack = new Stack<SweepStakes>();
        }
        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            SweepStakeStack.Push(sweepstakes);
        }
        public SweepStakes GetSweepstakes()
        {
            
            SweepStakes NextUp = SweepStakeStack.Pop();
             return NextUp;
        }


    }
}
