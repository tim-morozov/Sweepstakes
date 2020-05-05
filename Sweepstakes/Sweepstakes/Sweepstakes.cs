using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
       public Dictionary<int, Contestant> contestants;
       public string name;
       public Contestant winner;
        public int sweepstakesSize;
       
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
            sweepstakesSize = UserInterface.NumberOfContestants();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNum, contestant); 
        }

        public Contestant PickWinner()
        {
            Contestant winner = null;
            Random random = new Random();
            int picked = random.Next(1, contestants.Count);
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(picked == contestant.Key)
                {
                    winner = contestant.Value;
                }
            }
            return winner;
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
