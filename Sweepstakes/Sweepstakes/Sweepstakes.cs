﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Contestant contestant = new Contestant();
        public void Sweepstake(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public Contestant PickWinner()
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.Email);
            Console.WriteLine(contestant.RegistrationNum);
        }
    }
}
