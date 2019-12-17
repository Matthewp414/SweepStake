using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant 
    {
        
        public string firstName;
        public string lastName;
        public string email;
        public string name;
        // Registration Number
        int regNumber;

        public Contestant()
        {
            GetInfo();
            name = lastName + " " + firstName;
        }
        public void GetInfo()
        {
            this.firstName = UserInterface.GetFirstName();
            this.lastName = UserInterface.GetLastName();
            this.email = UserInterface.GetEmail();
            regNumber = UserInterface.GetRegNum();

        }
       

    }
}
