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
        Manager manager;

        public MarketingFirm(Manager manager)
        {
           this.manager = manager;
        }

        private void CreateSweepstakes()
        {
            string name = UserInterface.NameSweepstakes();
            newSweepstakes = new Sweepstakes(name);
           
        }

        public void RunSweepstakes()
        {
            CreateSweepstakes();
            while (newSweepstakes.contestants.Count < newSweepstakes.sweepstakesSize)
            {
                Contestant newContestant = new Contestant();
                newSweepstakes.RegisterContestant(newContestant);
            }
           newSweepstakes.winner = newSweepstakes.PickWinner();
            Console.WriteLine("The winner is: ");
            newSweepstakes.PrintContestantInfo(newSweepstakes.winner);
            UserInterface.ResetRegistration();
        }

        public void AddSweepstakes()
        {
            manager.InsertSweepstakes(newSweepstakes);
        }

    }
}
