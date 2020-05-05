using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweepstakesStack;
        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes;
            sweepstakes = sweepstakesStack.Pop();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
    }
}
