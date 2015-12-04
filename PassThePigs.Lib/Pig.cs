using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassThePigs.Lib
{
    public class Pig : Die
    {
        public Pig()
            : base(6)
        {

        }

        public PigPosition Position
        {
            get
            {
                return (PigPosition)this.LastRoll;
            }
        }

        public static string GetPositionName(PigPosition position)
        {
            string name = string.Empty;

            switch(position)
            {
                case PigPosition.PigOnSide:
                    name = "Pig on Side";
                    break;
                case PigPosition.PigOnSideWithDot:
                    name = "Pig on Side with Dot showing";
                    break;
                case PigPosition.Razorback:
                    name = "Razorback";
                    break;
                case PigPosition.Snouter:
                    name = "Snouter";
                    break;
                case PigPosition.Trotter:
                    name = "Trotter";
                    break;
                case PigPosition.LeaningJowler:
                    name = "Leaning Jowler";
                    break;
            }

            return name;
        }

        public static int CalculateScore(Pig pig)
        {
            int score = 0;

            switch (pig.Position)
            {
                case PigPosition.Razorback:
                case PigPosition.Trotter:
                    score = 5;
                    break;
                case PigPosition.Snouter:
                    score = 10;
                    break;
                case PigPosition.LeaningJowler:
                    score = 15;
                    break;
                default:
                    score = 0;
                    break;
            }

            return score;
        }

        public static int CalculateScore(Pig pig1, Pig pig2)
        {
            int score = 0;

            if(pig1.Position == pig2.Position)
            {
                switch(pig1.Position)
                {
                    case PigPosition.PigOnSide:
                    case PigPosition.PigOnSideWithDot:
                        score = 1;
                        break;
                    case PigPosition.Razorback:
                    case PigPosition.Trotter:
                        score = 20;
                        break;
                    case PigPosition.Snouter:
                        score = 40;
                        break;
                    case PigPosition.LeaningJowler:
                        score = 60;
                        break;
                }
            }
            else
            {
                if((pig1.Position == PigPosition.PigOnSide && pig2.Position == PigPosition.PigOnSideWithDot) || (pig1.Position == PigPosition.PigOnSideWithDot && pig2.Position == PigPosition.PigOnSide))
                {
                    // Pig Out!
                    score = -1;
                }
                else
                {
                    // mixed combo
                    score = Pig.CalculateScore(pig1) + Pig.CalculateScore(pig2);
                }
            }

            return score;
        }
    }
}
