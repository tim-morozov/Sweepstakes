using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<string, string> contestants = new Dictionary<string, string>();
        Contestant contestant = new Contestant();
        public void Sweepstake(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant = new Contestant();

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
