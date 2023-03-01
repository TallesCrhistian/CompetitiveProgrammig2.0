using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgrammig2.Tests
{
    public class ListFilteringTest
    {
        ListFiltering _listFilteringTest;

        [SetUp]
        public void SetUp()
        {
            _listFilteringTest = new ListFiltering();
        }

        [Test]
        public void GetIntegersFromList_ReturnNumbers()
        {
            List<object> list = new List<object>() { 1, 2, "a", "b" };
            IEnumerable<int> expectedResult = new List<int>() { 1, 2 };

            IEnumerable<int> result = _listFilteringTest.GetIntegersFromList(list);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GetIntegersFromList_ReturnNumbers2()
        {
            List<Object> list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            IEnumerable<int> expectedResult = new List<int>() { 1, 2, 123 };

            IEnumerable<int> result = _listFilteringTest.GetIntegersFromList(list);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
