
namespace CompetitiveProgrammig2.Tests
{
    public class FindTheUniqueNumberTest
    {
        FindTheUniqueNumber _findTheUniqueNumber;

        [SetUp]
        public void SetUp()
        {
            _findTheUniqueNumber = new FindTheUniqueNumber();
        }

        [Test]
        public void GetUnique_FindDifferentNumber()
        {
            IEnumerable<int> number = new int[] { 11, 11, 14, 11, 11 };
            int expectedResult = 14;

            int result = _findTheUniqueNumber.GetUnique(number);

            Assert.That(expectedResult == result);
        }
    }
}
