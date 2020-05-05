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
        Manager manager;

        private void CreateSweepstakes()
        {
            string name = UserInterface.NameSweepstakes();
            newSweepstakes = new Sweepstakes(name);
        }

        private void ChooseSize()
        {
            sweepstakesSize = UserInterface.NumberOfContestants();
        }

        public void RunSweepstakes()
        {
            Contestant winner;
            CreateSweepstakes();
            while (newSweepstakes.contestants.Count <= sweepstakesSize)
            {
                Contestant newContestant = new Contestant();
                newSweepstakes.RegisterContestant(newContestant);
            }
            winner = newSweepstakes.PickWinner();
            newSweepstakes.PrintContestantInfo(winner);
            UserInterface.ResetRegistration();
        }
    }
}
