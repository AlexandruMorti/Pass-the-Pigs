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
        private static Random _random = new Random();

        protected int _sides;
        private int _lastRoll;

        public Die()
        {
            _sides = 6;
        }
        
        public int Value
        {
            get
            {
                // return the value last rolled
                return _lastRoll;
            }
        }

        public virtual void roll()
        {
            _lastRoll = _random.Next(1, _sides);
        }



    }
}
