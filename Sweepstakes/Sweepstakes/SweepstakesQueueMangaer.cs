using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueMangaer : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue;
        public SweepstakesQueueMangaer()
        {
            sweepstakesQueue = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            
        }
    }
}
