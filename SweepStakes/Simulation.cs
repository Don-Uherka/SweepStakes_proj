using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        //variables

        //constructor

        //method
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager stack = new SweepstakesStackManager();
            ISweepstakesManager queue = new SweepstakesQueueManager();
            MarketingFirm marketingFirm = new MarketingFirm(queue);
            MarketingFirm marketing = new MarketingFirm(stack);
        }
    }
}
