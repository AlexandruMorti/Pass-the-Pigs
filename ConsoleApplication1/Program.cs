using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: Rename the project to something like PassThePigs.Console and use this as the namespace
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ● Create a console application which outputs a random number between 1 and 6
               ● Change the program so it asks the user how many dice to roll and then outputs:
                        ● The individual value of each dice
                        ● The number of dice rolled
                        ● The total value of all the dice summed up
               ● Create a class which represents a ‘die’ and restructure the program in 2 to use this
               ● Create a child class of your ‘die’ which represents the ‘pigs’ in Pass the Pigs
               ● Update your program so that running it simulates the throwing/rolling of 2 ‘Pigs’
               ● Add code to calculate the score of a throw as in 5, based on the rules in WikiPedia
               ● Update your program so that it can run a simulation of a ‘game’ of Pass the pigs with one computer and one human player
                       ● To start with, consider a ‘game’ to be 5 throws and whoever has the highest score wins
                       ● Review the rules and make notes here on any other considerations to be added to create the full game rules
                */


            //   ● Create a console application which outputs a random number between 1 and 6
            /*
                        Random roll = new Random();

                        // TODO: It might make more sense to have rollDice1 and rollDice2 so it's clear they are 1+2 of the same thing
                        // TODO: Would be tempted to just call it 'roll1' and 'roll2' as you know it's a die/dice, but not essential

                        int roll1 = roll.Next(1, 7);
                        int roll2 = roll.Next(1, 7);

                        // TODO: This should be called 'playerChoice' - pascalCase for variables, please :)

                        string playerChoice;
                        int myValue = 0;

                        // ● Change the program so it asks the user how many dice to roll and then outputs:
                        //            ● The individual value of each dice
                        //            ● The number of dice rolled
                        //            ● The total value of all the dice summed up

             * // Ask the user how many dice to roll

                        Console.WriteLine("How many dice do you want to roll?(1/2)");
                        playerChoice = Console.ReadLine();
                        if (playerChoice == "1")
                        {
                            //Outputs the individual value of 1 dice
                            Console.Write("You chosed {0} dice and the number is: ", playerChoice);
                            Console.WriteLine(roll1);
                        }
                        // TODO: You could just do 'else' - or use a switch
                        // TODO: What happens if the player puts in 3? ;)
                        else if (playerChoice != "2")
                        {
                            Console.Out.WriteLine("Nice try!");
                        }
                        else
                        {
                            if (!int.TryParse(playerChoice, out myValue))
                            {
                                Console.Out.WriteLine("Nice try!");
                            }
                            else
                            {
                                //Outputs the individual value of 2 dices
                                Console.WriteLine("You chosed {0} dices and the numbers are:", playerChoice);
                                Console.WriteLine(roll1);
                                Console.WriteLine(roll2);
                                // ● The total value of all the dice summed up
                                Console.WriteLine("and the sum of the 2 dices is :");
                                Console.WriteLine((roll1) + (roll2));
                            }
                        }
            */


     


            // roll two pigs

            Pigs pig1 = new Pigs();
            Pigs pig2 = new Pigs();

            pig1.roll();
            pig2.roll();

            Console.Out.WriteLine(pig1.Value);
            Console.Out.WriteLine(pig1.Description);
            Console.Out.WriteLine(pig1.Description);

            Console.Out.WriteLine();

            Console.Out.WriteLine(pig2.Value);
            Console.Out.WriteLine(pig2.Description);


            Console.Out.WriteLine();

            int score = Program.calculateScore(pig1, pig2);

            Console.Out.WriteLine("Total score for this round is " + " " + (score) + " " + "points");

            // 13. Once scoring is calculating correctly for a single round, wrap the code above (starting from 'roll'?) in a loop to test it

            // 14. How might this be extended to two players taking turns?

            // 15. In reality, players can have more than one roll (hence pig out / makin bacon rules) per turn - how can we do this?

            //do {
            //     int i = 0;
            //     while (i <= 1)
            //            {
            //                int thisThrow = score;
            //                DiceThrow[0 + i] += thisThrow;
            //                Console.ReadLine();
            //                Console.Write(score[0 + i] + " rolled a " + thisThrow);
            //                if (thisThrow != 5) i++;
            //            }


            //      }


            Console.ReadLine();
        }



        private static int calculateScore(Pigs pig1, Pigs pig2)
        {
            /*
             * Single pig
                The pig is lying on its side - 0 Points
                Razorback - The pig is lying on its back - 5 Points
                Trotter - The pig is standing upright - 5 Points
                Snouter - The pig is leaning on its snout - 10 Points
                Leaning Jowler - The pig is resting on its snout and ear - 15 Points

             * Both pigs
                Sider - The pigs are on their sides, either both with the spot facing upward or both with the spot facing downward - 1 Point
                Double Razorback - The pigs are both lying on their backs - 20 Points
                Double Trotter - The pigs are both standing upright - 20 Points
                Double Snouter - The pigs are both leaning on their snouts - 40 Points
                Double Leaning Jowler - The pigs are both resting between snouts and ears - 60 Points
                Mixed Combo - A combination not mentioned above is the sum of the single pigs' scores
                Pig Out - If both pigs are lying on their sides, one with the spot facing upwards and one with the spot facing downwards the score for that turn is reset to 0 and the turn changes to the next player
                Makin' Bacon (or Oinker) - If both pigs are touching in any position,[2] then the total score is reset to 0 and the turn changes to the next player
                Piggyback - If one pig lands completely resting on top of the other, then the player is out of the game. (According to the scoring rules on the front of the game package such a result is impossible.)
             */

            // 1. Check if the throw matches any combinations
            
            // 2. Ignore 'mixed combo' as this is just adding up the single scores
            // 3. Makin' bacon / Piggyback are a special case to come back to later (once probabilities are introduced)
            // 4. Pig Out - we may need to introduce the notion of 'which side' the pig is on, so come back to later

            // 5. This leaves the 'simple' combinations where the pigs are showing the same value
            // 6. This should be easy to work out and look up in a score dictionary (create dictionaries at the top of this method for now)

            // 7. If no combination is matched, the score for the throw is the sum of the individual scores (already in dictionary in pig class)

            // 8. return the total score

            // 9. Come back to 'pig out' - add a 6th 'side' to pig which is 'on side, with spot' (current 'on side' becomes 'on side, no spot'
            // 10. Bearing in mind the above, implement a case to catch 'pig out' in this method and return 0
            
            // 11. Create a class called 'Score' and move this method to it as a static method
            // 12. We can use this class in the future (an instance) to track the scores for a whole game
            return 0;
        }
    }
}
