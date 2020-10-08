using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        //variables
        ISweepstakesManager _manager;
        

        //constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }
        //method
        public void CreateSweepstake(string name)
        {
            Sweepstakes sweepstakes = new Sweepstakes("name");
        }
        
    }
}
