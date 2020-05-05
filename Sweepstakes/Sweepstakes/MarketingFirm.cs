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
        int sweepstakesSize;

        private void CreateSweepstakes()
        {
            string name = UserInterface.NameSweepstakes();
            newSweepstakes = new Sweepstakes(name);
        }

        private void ChooseSize()
        {

        }

        public void RunSweepstakes()
        {
            Contestant winner;
            CreateSweepstakes();
            newSweepstakes.RegisterContestant(newContestant);
            winner = newSweepstakes.PickWinner();

        }
    }
}
