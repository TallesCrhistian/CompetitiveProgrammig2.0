namespace CompetitiveProgrammig2.Tests
{
    public class HighestAndLowestTest
    {
        HighestAndLowest _highestAndLowest;

        [SetUp]
        public void SetUp()
        {
            _highestAndLowest= new HighestAndLowest();
        }

        [TestCase ("8 3 -5 42 -1 0 0 -9 4 7 4 -4", "42 -9" )]
        public void HighAndLow(string numbers, string expectedResult) 
        {
            string result = _highestAndLowest.HighAndLow(numbers);

            Assert.That(expectedResult == result);
        }
    }
}
