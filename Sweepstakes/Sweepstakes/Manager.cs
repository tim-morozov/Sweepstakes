using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    abstract class Manager : ISweepstakesManager
    {
        public abstract Sweepstakes GetSweepstakes();

        public abstract void InsertSweepstakes(Sweepstakes sweepstakes);
        
    }
}
