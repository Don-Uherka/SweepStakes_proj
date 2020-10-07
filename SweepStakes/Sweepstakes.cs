using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        //variables
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;

        //constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }
        //method
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
            //this just should be done with the variables in the contestant class?
        }
        public Contestant PickWinner()
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            //this will be the same information as the RegisterContestant method?
        }
    }
}
