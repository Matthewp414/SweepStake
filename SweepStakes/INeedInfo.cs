using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    interface INeedInfo
    {
        public void GetInfo(string FirstName, string LastName, string Email, int registrationNum);
            
    }
}
