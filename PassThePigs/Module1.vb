using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Namespace GuessANumber
{
    Class Program
    {
        static void Main(string[] args)
        {
            /*●	Write a program which picks a random number between 1 and 100. Ask the user to guess the number. Tell them when they get it right (and then exit)
              ●	Instead of exiting, ask the user if they would like to play again
              ●	Give the user a hint - “Higher!” or “Lower!” depending on how close their guess was
              ●	If the user is close (within 5 or 10 - you decide), then give them more help - “Almost! But Lower!”, etc
              ●	Keep track of the number of guesses the user has to make and tell them how many it took at the end
              ●	Track how long (in seconds or minutes) it takes the user to guess correctly and let them know when they get it right
              ●	Allow the user to set the upper and lower limits when they start the game (wrap your logic in a class, so that you pass these values in when starting up)
              ●	Write the same program, but the other way around! Make a program which will try to guess a number you are thinking of. Make it react to feedback such as “lower, higher”, etc!
             */




            //*●	Write a program which picks a random number between 1 and 100. Ask the user to guess the number. Tell them when they get it right (and then exit)//




            // 1.Picks a random number between 1 and 100.//

            bool userAnswer = false;

            string userChoice;

            Random random = new Random();
            int numberToGuess = random.Next(1) + 1;
            int userGuess = 0;


            while (userGuess != numberToGuess)

            {




                // 2. Ask the user to guess the number.



                Console.Write("Enter your guess: ");
                int.TryParse(Console.ReadLine(), out userGuess);




                // 3. Tell them when they get it right (and then exit).

                // if wrong print - wrong ask again
                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("{0} is too high!", userGuess);
                }


                 //if right - congratulate
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("{0} is too low!", userGuess);
                }


                else
                {

                    //  ●	Instead of exiting, ask the user if they would like to play again

                    //ask the user if they would like to play again

                    Console.WriteLine("{0} is right! Do you want to start again?(y/n).", userGuess);


                    userChoice = Console.ReadLine();


                    //if no exit


                    if (userChoice == "n")

                    {
                        Console.WriteLine("Thanks for playing!");

                    }

                         //if yes play again



                    else if (userChoice == "y")
                    {
                        userAnswer = false;
                    }


                }


            }

            Console.ReadKey();

        }
        }
    }

