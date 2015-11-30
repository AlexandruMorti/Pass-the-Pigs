using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Combinations : Pigs

    {
         private Dictionary<int, string> dictionary3;
         private Dictionary<int, int> dictionary4;

        public Combinations()
            {

                this._sides = 7;


                dictionary3 = new Dictionary<int, string>();
                dictionary3.Add(1, "Mixed Combo -One pig is lying on its side and the other one is lying on its back  ");
                dictionary3.Add(2, "Mixed Combo -One pig is lying on its side and the other one is standing upright  ");
                dictionary3.Add(3, "Mixed Combo -One pig is lying on its side and the other one is leaning on its snout  ");
                dictionary3.Add(4, "Mixed Combo -One pig is lying on its side and the other one is resting on its snout and ear  ");
                dictionary3.Add(5, "Pig Out - If both pigs are lying on their sides, one with the spot facing upwards and one with the spot facing downwards the score for that turn is reset to 0 and the turn changes to the next player");
                dictionary3.Add(6, "Makin' Bacon (or Oinker) - If both pigs are touching in any position,[2] then the total score is reset to 0 and the turn changes to the next player");
                dictionary3.Add(7, "Piggyback - If one pig lands completely resting on top of the other, then the player is out of the game.");

                dictionary4 = new Dictionary<int, int>();
                dictionary4.Add(1, 5);
                dictionary4.Add(2, 5);
                dictionary4.Add(3, 10);
                dictionary4.Add(4, 15);
                dictionary4.Add(5, 0);
                dictionary4.Add(6, 0);
                dictionary4.Add(7, 0);

            }
        public string MixedDescription
        {
            get
            {
                // return the value last rolled
                return dictionary3[this.Value];
            }
        }


    }

    
}
