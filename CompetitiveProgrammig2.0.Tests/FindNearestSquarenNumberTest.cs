namespace CompetitiveProgrammig2.Tests
{
    public class FindNearestSquarenNumberTest
    {
        FindNearestSquareNumber _findNearestSquarenNumber;

        [SetUp]
        public void SetUp()
        {
            _findNearestSquarenNumber = new FindNearestSquareNumber();
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(10, 9)]
        [TestCase(111, 121)]
        [TestCase(9999, 10000)]
        public void NerestSq_Square(int n, int expectedResult)
        {
            int result = _findNearestSquarenNumber.NearestSq(n);

            Assert.That(expectedResult == result);
        }
    }
}
