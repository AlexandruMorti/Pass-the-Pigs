﻿using System;
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


            Console.Out.WriteLine();

            Console.Out.WriteLine(pig2.Value);
            Console.Out.WriteLine(pig2.Description);


            Console.Out.WriteLine();

            int score = Program.calculateScore(pig1, pig2);

            Console.Out.WriteLine("Total score for this round is " + " " + (score) + " " + "points");

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
            return 0;
        }
    }
}
