using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//● Create a class which represents a ‘die’ and restructure the program in 2 to use this

namespace ConsoleApplication1
{
    class Die
    {


        public Die()
        { 

        }


        public int roll()
        {
            Random roll = new Random();
            int rollDice;
            rollDice = roll.Next(1, 7);
  
            return rollDice;
        }

        public int roll2()
        {

        }

    }
}
