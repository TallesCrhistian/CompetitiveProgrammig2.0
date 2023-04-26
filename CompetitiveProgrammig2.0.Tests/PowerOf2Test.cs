using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgrammig2.Tests
{
    internal class PowerOf2Test
    {
        Power_of_2 _power_Of_2;

        [SetUp]
        public void SetUp()
        {
            _power_Of_2 = new Power_of_2();
        }

        [TestCase(2)]
        public void Past_Milliseconds(int n)
        {
            BigInteger[] expectedResult = { 1, 2, 4 };
            BigInteger[] result = _power_Of_2.PowersOfTwo(n);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
