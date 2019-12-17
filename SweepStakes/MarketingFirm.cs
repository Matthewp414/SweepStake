using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        public MarketingFirm(IManager Manger)
        {

        }
        public Qmanager MakeLineUpWithQ()
        {
            Qmanager QueueStakes = new Qmanager();
            return QueueStakes;
        }
        public StackManager MakeLineUpWithStack()
        {
            StackManager StackStakes = new StackManager();
            return StackStakes;
        }
    }
}
