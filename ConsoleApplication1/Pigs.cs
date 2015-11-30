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
        private Dictionary<int, string> dictionary1;
        private Dictionary<int, int> dictionary2;
      
 

        public Pigs()
        {
            // set number of sides in the dice to 5
            this._sides = 5;

            // initialise lookup of values vs descriptions
            
            dictionary1 = new Dictionary<int, string>();
            dictionary1.Add(1, "The pig is lying on its side");
            dictionary1.Add(2, "Razorback - The pig is lying on its back");
            dictionary1.Add(3, "Trotter - The pig is standing upright");
            dictionary1.Add(4, "Snouter - The pig is leaning on its snout");
            dictionary1.Add(5, "Leaning Jowler - The pig is resting on its snout and ear");


            dictionary2 = new Dictionary<int, int>();
            dictionary2.Add(1, 0);
            dictionary2.Add(2, 5);
            dictionary2.Add(3, 5);
            dictionary2.Add(4, 10);
            dictionary2.Add(5, 15);

        }

   

        public string Description
        {
            get
            {
                // return the value last rolled
                return dictionary1[this.Value];
            }
        }
    }
}