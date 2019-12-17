using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        static public string GetSweepStake()
        {
            Console.WriteLine("What is the name of your sweepstake");
            return Console.ReadLine();
        }
        static public string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }
        static public string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }
        static public string GetEmail()
        {
            Console.WriteLine("What is your email?");
            return Console.ReadLine();
        }
        static public int  GetRegNum()
        {
            int refNumb = 0;
            bool test = false;
            while(test == false)
            {
                Console.WriteLine("What is your email?");
                test = Int32.TryParse(Console.ReadLine(), out refNumb);

            }
            return refNumb;
           
        }

    }
        
}
