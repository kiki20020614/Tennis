using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class TennisTest
    {
        [Test]
        public void WhenStart_Return0vs0()
        {
            var expected = "0:0";

            Assert.AreEqual(expected, Tennis.Scores(""));
        }

        [Test]
        public void WhenPlayerWonOrderIsA_Return15vs0()
        {
            var expected = "15:0";

            Assert.AreEqual(expected, Tennis.Scores("A"));
        }

        [Test]
        public void WhenPlayerWonOrderIsAA_Return30vs0()
        {
            var expected = "30:0";

            Assert.AreEqual(expected, Tennis.Scores("AA"));
        }

        [Test]
        public void WhenPlayerWonOrderIsAAA_Return40vs0()
        {
            var expected = "40:0";

            Assert.AreEqual(expected, Tennis.Scores("AAA"));
        }

        [Test]
        public void WhenPlayerWonOrderIsB_Return0vs15()
        {
            var expected = "0:15";

            Assert.AreEqual(expected, Tennis.Scores("B"));
        }

        [Test]
        public void WhenPlayerWonOrderIsBB_Return0vs30()
        {
            var expected = "0:30";

            Assert.AreEqual(expected, Tennis.Scores("BB"));
        }

        [Test]
        public void WhenPlayerWonOrderIsAAB_Return30vs15()
        {
            var expected = "30:15";

            Assert.AreEqual(expected, Tennis.Scores("AAB"));
        }

        [Test]
        public void WhenPlayerWonOrderIsAABB_Return30vs30()
        {
            var expected = "30:30";

            Assert.AreEqual(expected, Tennis.Scores("AABB"));
        }

        [Test]
        public void WhenPlayerWonOrderIsAABB_Return40vs30()
        {
            var expected = "40:30";

            Assert.AreEqual(expected, Tennis.Scores("AAABB"));
        }

        [Test]
        public void WhenPlayerWonOrderIsAAABBB_ReturnDeuce()
        {
            var expected = "deuce";

            Assert.AreEqual(expected, Tennis.Scores("AAABBB"));
        }
    }
}
