using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {

        
        
        static void Ask8Ball(IDeliverable eightBall)
        {
            eightBall.deliver();
        }

        public static IDeliverable ToEightBall(string queryString)
        {
            
            if(queryString == "nice")
            {
                var nice8Ball = new Nice8Ball();
                return nice8Ball;
            }
            else if(queryString == "mean")
            {
                var mean8Ball = new Mean8Ball();
                return mean8Ball;
            }
            else 
            {
                var neutral8Ball = new Neutral8Ball();
                return neutral8Ball;
            }
        }

        static void Main(string[] args)
        {
            Random rng = new Random();
            List<string> eightBalls = new List<string>() { "neutral", "mean", "nice" };
            string ball;
            string trash;

            Console.WriteLine("Please Type your question to the Magic 8 Ball");
            trash = Console.ReadLine();
            ball = eightBalls[rng.Next(eightBalls.Count)];
            var pickedBall = ToEightBall(ball);
            Ask8Ball(pickedBall);
        }
    }
}

