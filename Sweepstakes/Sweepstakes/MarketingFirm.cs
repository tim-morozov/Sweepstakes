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
            ChooseSize();
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
            Console.WriteLine("The winner is: ");
            newSweepstakes.PrintContestantInfo(winner);
            UserInterface.ResetRegistration();
        }

        public void Manager()
        {
            manager = UserInterface.ChooseManager();
            manager.InsertSweepstakes(newSweepstakes);
        }
    }
}
