using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassThePigs.Lib;

namespace PassThePigsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a Die which we can roll
            Die die1 = new Die();
            die1.Roll();
            Console.Out.WriteLine("die1 rolled {0}", die1.LastRoll);

            Die die2 = new Die(20);
            die2.Roll();
            Console.Out.WriteLine("die2 rolled {0}", die2.LastRoll);

            // 2. Create a 'pig' based on that die
            Pig pig1 = new Pig();
            pig1.Roll();
            Console.Out.WriteLine("pig1 rolled {0}", pig1.LastRoll);
            Console.Out.WriteLine("pig1 landed {0}", Pig.GetPositionName(pig1.Position));

            // 3. Work out the score for a single pig 
            int score = Pig.CalculateScore(pig1);
            Console.Out.WriteLine("pig1 scored {0}", score);

            // 4. Look at how we can work out the score from a throw of 2 pigs
            Pig pig2 = new Pig();
            pig2.Roll();
            Console.Out.WriteLine("pig2 rolled {0}", pig2.LastRoll);
            Console.Out.WriteLine("pig2 landed {0}", Pig.GetPositionName(pig2.Position));

            /*
             * Both pigs

             * Makin' Bacon (or Oinker) - If both pigs are touching in any position,[2] then the total score is reset to 0 and the turn changes to the next player
             */

            int totalScore = Pig.CalculateScore(pig1, pig2);
            Console.Out.WriteLine();
            Console.Out.WriteLine("Total Score = {0}", totalScore);

            // wait for a keypress before exiting
            Console.Out.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
