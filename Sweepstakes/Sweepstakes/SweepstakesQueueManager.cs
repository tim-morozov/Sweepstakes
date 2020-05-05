using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : Manager , ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue;
        public SweepstakesQueueManager()
        {
            sweepstakesQueue = new Queue<Sweepstakes>();
        }
        public override Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes;
            sweepstakes = sweepstakesQueue.Dequeue();
            return sweepstakes;
        }

        public override void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}
