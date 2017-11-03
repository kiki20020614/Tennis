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
    }
}
