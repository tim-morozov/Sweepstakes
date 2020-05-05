using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        public string name;
       
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant = new Contestant();
            contestants.Add(contestant.RegistrationNum, contestant);

        }

        public Contestant PickWinner()
        {            
            Random random = new Random();
            int picked = random.Next(1, contestants.Count);
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(picked == contestant.Key)
                {
                    return contestant.Value;
                }
            }
            return null;
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
