using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassThePigs.Lib
{
    public class Die
    {
        private static Random _random = new Random();

        public Die()
            : this(6)
        {
        }

        public Die(int sides)
        {
            this.Sides = sides;
        }

        public int Sides { get; private set; }

        public int LastRoll { get; private set; }

        public void Roll()
        {
            this.LastRoll = _random.Next(1, this.Sides);
        }
    }
}
