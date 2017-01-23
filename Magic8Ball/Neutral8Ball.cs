using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Neutral8Ball : IDeliverable
    {
       
        Random rng = new Random();
        List<String> neutralAnswers = new List<string>()
        {
            "Not even I know that",
            "Tell me more"
        };


        public void deliver()
        {
            BeNeutral();
        }

        private void BeNeutral()
        {
            Console.WriteLine(neutralAnswers[rng.Next(neutralAnswers.Count)]);
        }
    }
}
