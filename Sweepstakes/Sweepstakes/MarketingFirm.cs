﻿using System;
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

        public MarketingFirm()
        {
            manager = UserInterface.ChooseManager();
        }

        private void CreateSweepstakes()
        {
            string name = UserInterface.NameSweepstakes();
            newSweepstakes = new Sweepstakes(name);
           
        }

        public void RunSweepstakes()
        {
            CreateSweepstakes();
            while (newSweepstakes.contestants.Count < sweepstakesSize)
            {
                Contestant newContestant = new Contestant();
                newSweepstakes.RegisterContestant(newContestant);
            }
           newSweepstakes.winner = newSweepstakes.PickWinner();
            Console.WriteLine("The winner is: ");
            newSweepstakes.PrintContestantInfo(newSweepstakes.winner);
            UserInterface.ResetRegistration();
        }

        public void Manager()
        {
            manager = UserInterface.ChooseManager();
            manager.InsertSweepstakes(newSweepstakes);
        }
    }
}
