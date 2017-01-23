using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Mean8Ball : IDeliverable
    {
       
        Random rng = new Random();
        List<String> meanAnswers = new List<string>()
        {
            "Not in a million years",
            "No Way Jose",
            "You Suck, So No"
        };
        public void deliver()
        {
            BeMean();
        }

        private void BeMean()
        {
            Console.WriteLine(meanAnswers[rng.Next(meanAnswers.Count)]);

        }
    }
}

