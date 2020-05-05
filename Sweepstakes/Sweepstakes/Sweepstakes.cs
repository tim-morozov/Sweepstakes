using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, string> contestants = new Dictionary<int, string>();
        Contestant contestant = new Contestant();
        public void Sweepstake(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant = new Contestant();
            contestants.Add(contestant.RegistrationNum, contestant.LastName);

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
