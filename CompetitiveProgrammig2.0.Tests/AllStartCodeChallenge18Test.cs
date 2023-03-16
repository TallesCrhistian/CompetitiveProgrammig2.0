using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgrammig2.Tests
{
    internal class AllStartCodeChallenge18Test
    {
        AllStartCodeChallenge18 _allStartCodeChallenge18;

        [SetUp]
        public void SetUp()
        {
            _allStartCodeChallenge18 = new AllStartCodeChallenge18();
        }

        [TestCase("Hello", 'o', 1)]
        public void StrCount_occutencesLetter(string str, char letter, int expectedResult)
        {
            int result = _allStartCodeChallenge18.StrCount(str, letter);

            Assert.That(result == expectedResult);
        }
    }
}
