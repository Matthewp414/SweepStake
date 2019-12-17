using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakes
    {
        
        string name;
        Dictionary<int, string> Contestants = new Dictionary<int, string>();
        List<int> nameList;
        public SweepStakes()
        { 
            nameList = new List<int>(Contestants.Keys);
            name = UserInterface.GetSweepStake();
        }
        public void RegisterContestant(Contestant contestant)
        {
            Contestants.Add(contestant.regnumber, contestant.name);
        }
        public string  GetWinner()
        {
            Random random = new Random();
            int Winner = nameList[random.Next(nameList.Count)];
            return Winner;
            //pick random make the cap on the random num gen max
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            foreach( contestant in Contestants)
            {
                Console.WriteLine(contestant.firstName + " " + contestant.lastName + " Registration Number: " + contestant.regNumber);

            }
        }
    }
}
