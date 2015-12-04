using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassThePigs.Lib;
using NUnit.Framework;

namespace PassThePigs.Lib.Test
{
    [TestFixture]
    public class PigTest
    {
        /// <summary>
        /// Test that GetPositionName returns the right value for each position
        /// </summary>
        [Test]
        public void _001_GetPositionName()
        {
            Assert.That(Pig.GetPositionName(PigPosition.LeaningJowler), Is.EqualTo("Leaning Jowler"));
            Assert.That(Pig.GetPositionName(PigPosition.PigOnSide), Is.EqualTo("Pig On Side"));

            // TODO: Add the other positions here
            Assert.Fail();
        }

        [Test]
        public void _002_CalculateScore_SinglePig()
        {
            Assert.Fail();
        }

        [Test]
        public void _003_CalculateScore_SimpleCombination()
        {
            Pig pig1 = new Pig(PigPosition.Razorback);
            Pig pig2 = new Pig(PigPosition.Razorback);

            Assert.That(Pig.CalculateScore(pig1, pig2), Is.EqualTo(20));

////            Assert.Fail();
        }

        [Test]
        public void _004_CalculateScore_MixedCombo()
        {
            Assert.Fail();
        }
    }
}
