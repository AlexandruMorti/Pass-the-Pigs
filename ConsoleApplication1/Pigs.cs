using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//● Create a child class of your ‘die’ which represents the ‘pigs’ in Pass the Pigs


/*
    Single pig
1.The pig is lying on its side - 0 Points
2.Razorback - The pig is lying on its back - 5 Points
3.Trotter - The pig is standing upright - 5 Points4.
4.Snouter - The pig is leaning on its snout - 10 Points
5.Leaning Jowler - The pig is resting on its snout and ear - 15 Points
 * 
    Both pigs
1.Sider - The pigs are on their sides, either both with the spot facing upward or both with the spot facing downward - 1 Point
2.Double Razorback - The pigs are both lying on their backs - 20 Points
3.Double Trotter - The pigs are both standing upright - 20 Points
4.Double Snouter - The pigs are both leaning on their snouts - 40 Points
5.Double Leaning Jowler - The pigs are both resting between snouts and ears - 60 Points
6.Mixed Combo - A combination not mentioned above is the sum of the single pigs' scores
7.Pig Out - If both pigs are lying on their sides, one with the spot facing upwards and one with the spot facing downwards the score for that turn is reset to 0 and the turn changes to the next player
8.Makin' Bacon (or Oinker) - If both pigs are touching in any position,[2] then the total score is reset to 0 and the turn changes to the next player
9.Piggyback - If one pig lands completely resting on top of the other, then the player is out of the game. (According to the scoring rules on the front of the game package such a result is impossible.)

 */


namespace ConsoleApplication1
{
    class Pigs : Die
    {
        public Pigs()
        { 
            
        }

        if (playerChoice == "1")
		{
			//Outputs the individual value of 1 dice
			Console.Write("You chosed {0} pig and the result is: ", playerChoice);
			
			
			Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
			
		dictionary1.Add(1, "The pig is lying on its side - 0 Points");
		dictionary1.Add(2, "Razorback - The pig is lying on its back  - 5 Points");
		dictionary1.Add(3, "Trotter - The pig is standing upright  - 5 Points");
		dictionary1.Add(4, "Snouter - The pig is leaning on its snout - 10 Points ");
		dictionary1.Add(5, "Leaning Jowler - The pig is resting on its snout and ear - 15 Points");
			
			
					if (1 == pig1)
					{
						Console.WriteLine(dictionary1[1].ToString());
					}
			
					if (2 == pig1)
					{
						Console.WriteLine(dictionary1[2].ToString());
					}
			
					if (3 == pig1)
					{
						Console.WriteLine(dictionary1[3].ToString());
					}
			
					if (4 == pig1)
					{
						Console.WriteLine(dictionary1[3].ToString());
					}
			
					if (5 == pig1)
					{
						Console.WriteLine(dictionary1[5].ToString());
					}
			
						
			
		}

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
                    Console.WriteLine("You chosed to play {0} pigs and the result is:", playerChoice);
					
             
					Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
			
					dictionary2.Add(1, "1 Point - Sider - The pigs are on their sides, either both with the spot facing upward or both with the spot facing downward ");
					dictionary2.Add(2, "20 Points - Double Razorback - The pigs are both lying on their backs");
					dictionary2.Add(3, "20 Points - Double Trotter - The pigs are both standing upright");
					dictionary2.Add(4, "40 Points - Double Snouter - The pigs are both leaning on their snouts");
					dictionary2.Add(5, "60 Points - Double Leaning Jowler - The pigs are both resting between snouts and ears");
					dictionary2.Add(6, "Mixed Combo - A combination not mentioned above is the sum of the single pigs' scores");
					dictionary2.Add(7, "0 Points - Pig Out - If both pigs are lying on their sides, one with the spot facing upwards and one with the spot facing downwards the score for that turn is reset to 0 and the turn changes to the next player");
					dictionary2.Add(8, "0 Points - Makin' Bacon (or Oinker) - If both pigs are touching in any position,[2] then the total score is reset to 0 and the turn changes to the next player");
					dictionary2.Add(9, "Out of the game - Piggyback - If one pig lands completely resting on top of the other, then the player is out of the game. (According to the scoring rules on the front of the game package such a result is impossible.)");
					
					if (1 == pig2)
					{
						Console.WriteLine(dictionary2[1].ToString());	
					}
					if (2 == pig2)
					{
						Console.WriteLine(dictionary2[2].ToString());	
					}
					if (3 == pig2)
					{
						Console.WriteLine(dictionary2[3].ToString());	
					}
					if (4 == pig2)
					{
						Console.WriteLine(dictionary2[4].ToString());	
					}
					if (5 == pig2)
					{
						Console.WriteLine(dictionary2[5].ToString());	
					}
					if (6 == pig2)
					{
						Console.WriteLine(dictionary2[6].ToString());	
					}
					if (7 == pig2)
					{
						Console.WriteLine(dictionary2[7].ToString());	
					}
					if (8 == pig2)
					{
						Console.WriteLine(dictionary2[8].ToString());	
					}
					if (9 == pig2)
					{
						Console.WriteLine(dictionary2[9].ToString());	
					}
                }
            }
        }
