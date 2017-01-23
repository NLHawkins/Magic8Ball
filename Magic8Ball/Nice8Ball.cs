using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{

    class Nice8Ball : IDeliverable
    {
        
        Random rng = new Random();
        List<String> niceAnswers = new List<string>()
        {
            "Absolutely yes",
            "No doubt",
            "For Sure"
        };
        public void deliver()
        {
            BeNice();
        }

        private void BeNice()
        {

            Console.WriteLine(niceAnswers[rng.Next(niceAnswers.Count)]);
        }
    }
}
