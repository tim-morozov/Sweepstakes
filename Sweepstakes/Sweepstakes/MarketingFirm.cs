using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        Sweepstakes newSweepstakes;

        public void CreateSweepstakes()
        {
            string name = UserInterface.NameSweepstakes();
            newSweepstakes = new Sweepstakes(name);
        }
    }
}
